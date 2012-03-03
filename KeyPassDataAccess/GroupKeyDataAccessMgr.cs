using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;

namespace KeyPassDataAccess
{
    public class GroupKeysDictionary : Dictionary<Group, List<Key>> { }

    public static class GroupKeyDataAccessMgr
    {
        private static GroupKeysDictionary _groupKeys = new GroupKeysDictionary();

        public static void AddGroup(Group g)
        {
            _groupKeys.Add(g, new List<Key>());
        }

        public static void DeleteGroup(Group g)
        {
            _groupKeys.Remove(g);
        }

        public static List<Group> GetGroups() 
        {
            List<Group> g = new List<Group>();
            foreach (var kvp in _groupKeys)
	        {
                g.Add(kvp.Key);
	        }

            return g;
        }

        public static List<Key> GetKeysForGroup(Group g)
        {
            List<Key> k = new List<Key>();
            foreach (var kvp in _groupKeys)
            {
                // when the group is found, return the list of keys
                if (kvp.Key == g)
                {
                    k = kvp.Value;
                    break;
                }
            }

            return k;
        }

        public static void AddKeyToGroup(Group g, Key k)
        {
            List<Key> keys = new List<Key>();
            foreach (var kvp in _groupKeys)
            {
                // when the group is found, return the list of keys
                if (kvp.Key == g)
                {
                    kvp.Value.Add(k);
                    return;
                }
            }
        }

        public static void DeleteKeyFromGroup(Group g, Key k)
        {
            List<Key> keys = GetKeysForGroup(g);
            keys.Remove(k);
        }
    }
}
