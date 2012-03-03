using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;

namespace KeyPassBusiness
{
    public class Document
    {
        bool IsModified = true;

        public List<Group> Groups { get; set; }
    }
}
