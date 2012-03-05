using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;
using System.IO;

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
        public static event NewDocumentEventHandler NewDocumentCreated;
        public static event DocumentOpenedEventHandler DocumentOpened;

        private static Document _document = new Document();
        public static Document Document { get { return _document; } }

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

            using (var fileStream = new StreamWriter(fileName))
            {
                // serialize file to disk
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(_document.GetType());
                x.Serialize(fileStream, _document);
            }

            // reset the is modified flag
            _document.IsModified = false;
        }

        public static void OpenDocument(string fileName)
        {
            //TODO: error checking: if no filename exists

            using (var fileStream = new System.IO.FileStream(fileName, FileMode.Open))
            {
                // serialize file to disk
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(_document.GetType());
                _document = (Document)x.Deserialize(fileStream);
            }

            FireDocumentOpened();
        }
    }
}
