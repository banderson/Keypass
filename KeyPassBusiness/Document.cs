using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;
using System.Xml.Serialization;

namespace KeyPassBusiness
{
    public class Document
    {
        [XmlIgnore]
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
