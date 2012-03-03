using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyPassInfoModel
{
    public class Group
    {
        public string GroupName { get; set; }

        public List<Key> Keys { get; set; }

        public override string ToString()
        {
            return this.GroupName;
        }
    }
}
