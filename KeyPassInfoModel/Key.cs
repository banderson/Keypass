using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyPassInfoModel
{
    public class Key
    {
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return String.Format("Title: {0}\nUserName: {1}\nPassword: {2}\nURL: {3}\nNotes\n----------------------------------------------------------\n{4}",
                Title, UserName, Password, Url, Notes);
        }
    }
}
