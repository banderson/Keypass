using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;

namespace KeyPassBusiness
{
    public class Document
    {
        public bool IsModified = false;

        public string FilePath;

        public List<Group> Groups { get; set; }

        public Document()
        {
            Groups = new List<Group>();
            KeyPassMgr.DocumentChanged += HandleDocumentChangeEvent;
        }

        private void HandleDocumentChangeEvent()
        {
            IsModified = true;
        }
    }
}
