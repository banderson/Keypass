using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;

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

        private static Document _document = new Document();

        public static bool AddGroup(Group group)
        {
            _document.Groups.Add(group);
            
            if (GroupAdded != null)
            {
                GroupAdded.Invoke(group);
            }

            return true;
        }

        public static bool ModifyGroup(Group group)
        {
            if (GroupModified != null)
            {
                GroupModified.Invoke(group);
            }

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
        }

        public static void DeleteKey(Group g, Key k)
        {
            g.Keys.Remove(k);
            
            if (KeyDeleted != null)
            {
                KeyDeleted.Invoke(k);
            }
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
        }
    }
}
