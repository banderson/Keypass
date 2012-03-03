using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;

namespace KeyPassBusiness
{
    public delegate void GroupSelectedEventHandler(Group g);

    public static class ContextMgr
    {
        public static event GroupSelectedEventHandler GroupSelected = null;

        static Group _currentGroup;
        public static Group CurrentGroup
        {
            get
            {
                return _currentGroup;
            }
            set
            {
                _currentGroup = value;
                if (GroupSelected != null)
                {
                    GroupSelected(value);
                }
            }
        }

        static Key _currentKey;
        public static Key CurrentKey
        {
            get
            {
                return _currentKey;
            }
            set
            {
                _currentKey = value;
            }
        }

        // should probably be a property, but a field gets the job done...
        public static bool MultipleKeysSelected = false;

        public static void FireGroupSelected()
        {
            GroupSelected.Invoke(_currentGroup);
        }
    }
}
