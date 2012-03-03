using System;

namespace KeyPassBusiness
{
    public static class MyCompany
    {
        /// <summary>
        /// Public properties that describe the Company itself
        /// </summary>
        public static string Name {
            get
            {
                return "The Context Switch, Inc.";
            }
        }

        /// <summary>
        /// Public Properties that describe the product in use
        /// </summary>
        public static string ProductName {
            get
            {
                return "My Key Pass";
            }
        }

        public static string ProductAuthor
        {
            get
            {
                return "Ben Anderson";
            }
        }

        public static string ProductDescription { 
            get 
            {
                return "The program stores your passwords in a highly encrypted database. MyKeyPass supports password groups, subgroups, searching, drag & drop and auto-type. The program can export the database to various formats.";
            } 
        }

        public static string ProductVersion {
            get
            {
                return "1.0.0";
            }
        }
    }


}
