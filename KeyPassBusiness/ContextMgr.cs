using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;

namespace KeyPassBusiness
{
    public delegate void GroupSelectedEventHandler(Group group);
    public delegate void KeySelectedEventHandler(List<Key> keys);
    public delegate void GroupAddedEventHandler();

    public static class ContextMgr
    {
        public static event GroupSelectedEventHandler GroupSelected = null;
        public static event KeySelectedEventHandler KeySelected = null;
        public static event GroupAddedEventHandler GroupAdded = null;
        
        public static void Initialize()
        {
            _selectedKeys = new List<Key>();
            _currentGroup = null;
        }

        static Group _currentGroup;
        public static Group CurrentGroup
        {
            get { return _currentGroup; }
            set
            {
                _currentGroup = value;
                FireGroupSelected();
            }
        }

        // should probably be a property, but a field gets the job done...
        public static bool MultipleKeysSelected
        {
            get { return _selectedKeys.Count > 1; }
        }

        public static Key CurrentKey
        {
            get { return (_selectedKeys.Count > 0) ? _selectedKeys[0] : null; }
            set { _selectedKeys.Clear();  _selectedKeys.Add(value); }
        }

        static List<Key> _selectedKeys = new List<Key>();
        public static List<Key> SelectedKeys
        {
            get { return _selectedKeys; }
        }

        public static void FireGroupSelected()
        {
            _selectedKeys.Clear();

            if (GroupSelected != null)
                GroupSelected.Invoke(_currentGroup);

            FireKeySelected();
        }

        public static void FireGroupAdded()
        {
            if (GroupAdded != null)
                GroupAdded.Invoke();
        }

        public static void FireKeySelected()
        {
            if (KeySelected != null)
                KeySelected.Invoke(_selectedKeys);
        }
    }
}
