using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;
using KeyPassDataAccess;

namespace KeyPassBusiness
{
    public static class KeyPassMgr
    {

        public static bool AddGroup(Group g)
        {
            GroupKeyDataAccessMgr.AddGroup(g);
            return true;
        }

        public static bool AddKeyToGroup(Group g, Key k)
        {
            GroupKeyDataAccessMgr.AddKeyToGroup(g, k);
            return true;
        }

        public static bool DeleteGroup(Group g)
        {
            GroupKeyDataAccessMgr.DeleteGroup(g);
            return true;
        }

        public static List<Group> GetGroups()
        {
            return GroupKeyDataAccessMgr.GetGroups();
        }

        public static List<Key> GetKeysForGroup(Group g)
        {
            return GroupKeyDataAccessMgr.GetKeysForGroup(g);
        }

        public static void DeleteKeyFromGroup(Group g, Key k)
        {
            GroupKeyDataAccessMgr.DeleteKeyFromGroup(g, k);
        }

        public static void ModifyKey(Group group, Key k)
        {
            // find the group associated to the key k
            Group oldGroup = GroupKeyDataAccessMgr.FindGroupForKey(k);

            // if the group is different from the group param, then remove from old group and add to new one
            if (oldGroup != group)
            {
                GroupKeyDataAccessMgr.DeleteKeyFromGroup(oldGroup, k);
                GroupKeyDataAccessMgr.AddKeyToGroup(group, k);
            }
        }
    }
}
