using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Drawing.Printing;

namespace KeyPassBusiness
{
    public static class KeyPassMgr
    {
        // data-focused event handlers
        public static event GroupAddedEventHandler GroupAdded;
        public static event GroupModifiedEventHandler GroupModified;
        public static event GroupDeletedEventHandler GroupDeleted;
        public static event KeyAddedEventHandler KeyAdded;
        public static event KeyModifiedEventHandler KeyModified;
        public static event KeyDeletedEventHandler KeyDeleted;
        public static event DocumentChangedEventHandler DocumentChanged;
        public static event DocumentSavedEventHandler DocumentSaved;
        public static event NewDocumentEventHandler NewDocumentCreated;
        public static event DocumentOpenedEventHandler DocumentOpened;

        private static Document _document = new Document();
        public static Document Document { get { return _document; } }

        public static void CloneGroup(Group group)
        {
            Group clone = null;
            using (var ms = new MemoryStream())
            {
                // serialize group object, then rehydrate as new object graph
                var bf = new BinaryFormatter();
                bf.Serialize(ms, group);
                ms.Position = 0;

                clone = (Group)bf.Deserialize(ms);
            }
            
            KeyPassMgr.AddGroup(clone);
        }

        public static void CloneKey(Key key)
        {
            Key clone = null;
            using (var ms = new MemoryStream())
            {
                // serialize group object, then rehydrate as new object graph
                var bf = new BinaryFormatter();
                bf.Serialize(ms, key);
                ms.Position = 0;
                clone = (Key)bf.Deserialize(ms);
            }

            KeyPassMgr.AddKey(ContextMgr.CurrentGroup, clone);
        }

        public static bool AddGroup(Group group)
        {
            _document.Groups.Add(group);
            
            if (GroupAdded != null)
            {
                GroupAdded.Invoke(group);
            }

            FireDocumentChanged();

            return true;
        }

        public static bool ModifyGroup(Group group)
        {
            if (GroupModified != null)
            {
                GroupModified.Invoke(group);
            }

            FireDocumentChanged();

            return true;
        }

        public static bool DeleteGroup(Group group)
        {
            DeleteKeys(group);

            _document.Groups.Remove(group);

            if (GroupDeleted != null)
            {
                GroupDeleted.Invoke(group);
            }

            FireDocumentChanged();

            return true;
        }

        public static Group FindGroupForKey(Key key)
        {
            foreach (Group g in _document.Groups)
            {
                Key k = g.Keys.Find(s => s == key);
                if (k != null)
                    return g;
            }
            return null;
        }

        public static List<Group> GetGroups()
        {
            return _document.Groups;
        }

        public static List<Key> GetKeysForGroup(Group g)
        {
            return g.Keys;
        }

        public static bool AddKey(Group group, Key key)
        {
            group.Keys.Add(key);

            if (KeyAdded != null)
            {
                KeyAdded.Invoke(key);
            }

            FireDocumentChanged();

            return true;
        }

        public static void ModifyKey(Group group, Key k)
        {
            // find the group associated to the key k
            Group oldGroup = FindGroupForKey(k);

            // if the group is different from the group param, then remove from old group and add to new one
            if (oldGroup != group)
            {
                DeleteKey(oldGroup, k);
                AddKey(group, k);
            }

            if (KeyModified != null)
            {
                KeyModified.Invoke(k);
            }

            FireDocumentChanged();
        }

        public static void DeleteKey(Group g, Key k)
        {
            g.Keys.Remove(k);
            
            if (KeyDeleted != null)
            {
                KeyDeleted.Invoke(k);
            }

            FireDocumentChanged();
        }

        public static void DeleteKeys(Group group)
        {
            foreach (Key key in group.Keys)
            {
                if (KeyDeleted != null)
                {
                    KeyDeleted.Invoke(key);
                }
            }

            group.Keys.Clear();

            FireDocumentChanged();
        }

        public static void FireDocumentChanged()
        {
            if (DocumentChanged != null)
                DocumentChanged.Invoke();
        }

        public static void FireDocumentSaved()
        {
            if (DocumentSaved != null)
                DocumentSaved.Invoke();
        }

        public static void FireDocumentNew()
        {
            if (NewDocumentCreated != null)
                NewDocumentCreated.Invoke();
        }

        public static void FireDocumentOpened()
        {
            if (DocumentOpened != null)
                DocumentOpened.Invoke();
        }

        public static void NewDocument()
        {
            foreach (var group in _document.Groups)
            {
                // this method deletes the keys prior to the group
                DeleteKeys(group);
            }

            _document.Groups.Clear();

            _document = new Document();

            FireDocumentNew();
        }

        public static void SaveDocument(string fileName)
        {
            // open up file stream to selected file
            _document.FilePath = fileName;

            using (var ms = new MemoryStream())
            {
                // serialize file to disk
                var bf = new BinaryFormatter();
                bf.Serialize(ms, _document);

                File.WriteAllBytes(fileName, CryptoHelper.Encrypt(ms.ToArray()));
            }

            // reset the is modified flag
            _document.IsModified = false;

            FireDocumentSaved();
        }

        public static void OpenDocument(string fileName)
        {
            //TODO: error checking: if no filename exists

            using (var ms = new MemoryStream())
            {
                // serialize file from disk
                var input = CryptoHelper.Decrypt(File.ReadAllBytes(fileName));
                ms.Write(input, 0, input.Length);
                ms.Position = 0; // move back to beginning of stream

                var bf = new BinaryFormatter();
                _document = (Document)bf.Deserialize(ms);
            }

            // reset the is modified flag
            _document.IsModified = false;

            FireDocumentOpened();
        }

        public static void PrintPage(PrintPageEventArgs e)
        {
            int row = 1; // start on first row

            // adjust for margins
            Point origin = e.MarginBounds.Location; 
            e.Graphics.TranslateTransform(origin.X, origin.Y);

            // print header row
            PrintHeaderCell(e, 1, row, "Group");
            PrintHeaderCell(e, 2, row, "Title");
            PrintHeaderCell(e, 3, row, "User Name");
            PrintHeaderCell(e, 4, row, "Password");
            PrintHeaderCell(e, 5, row, "URL");
            PrintHeaderCell(e, 6, row, "Notes");
            row++;
            
            // print seection for each group and its related keys
            foreach (var group in KeyPassMgr.GetGroups())
            {
                row++;
                PrintHeaderCell(e, 1, row, group.GroupName);

                for (int i = 0; i < group.Keys.Count; i++)
                {
                    PrintDataCell(e, 2, row, group.Keys[i].Title);
                    PrintDataCell(e, 3, row, group.Keys[i].UserName);
                    PrintDataCell(e, 4, row, group.Keys[i].Password);
                    PrintDataCell(e, 5, row, group.Keys[i].Url);
                    PrintDataCell(e, 6, row, group.Keys[i].Notes);
                    row++;
                }
            }
        }

        private static void PrintCell(PrintPageEventArgs e, int column, int row, string text, Brush brush)
        {
            // dynamically determine the width of each column
            int cellHeight = 25;
            int cellWidth = 100;// (e.PageBounds.Width - e.PageSettings.Margins.Left - e.PageSettings.Margins.Top) / 6;

            // calculate the cell x/y location based on page dimensions
            int x = cellWidth * (column - 1), y = cellHeight * (row - 1);

            // draw cell
            var rect = new Rectangle(x, y, cellWidth, cellHeight);
            var g = e.Graphics;
            g.FillRectangle(brush, rect);
            g.DrawRectangle(Pens.Black, rect);

            // format text and add to cell
            Font messageFont = new Font("Segoe UI", 9, GraphicsUnit.Point);
            StringFormat mine = new StringFormat(StringFormat.GenericTypographic);
            mine.Trimming = StringTrimming.EllipsisCharacter;
            mine.Alignment = StringAlignment.Near;
            mine.LineAlignment = StringAlignment.Center;
            g.DrawString(" " + text, messageFont, Brushes.Black, rect, mine);
        }

        private static void PrintHeaderCell(PrintPageEventArgs e, int column, int row, string text)
        {
            PrintCell(e, column, row, text, Brushes.LightGray);
        }

        private static void PrintDataCell(PrintPageEventArgs e, int column, int row, string text)
        {
            PrintCell(e, column, row, text, Brushes.White);
        }
    }
}
