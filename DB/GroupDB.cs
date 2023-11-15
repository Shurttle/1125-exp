﻿
using System.Text.Json;

namespace ConsoleApp5.DB
{
    internal class GroupDB
    {
        Dictionary<string, Group> groups;

        public GroupDB()
        {
            //load file (json) 
            if (!File.Exists("group.json"))
                groups = new Dictionary<string, Group>();
            else
                using (FileStream fs = new FileStream("group.json", FileMode.OpenOrCreate))
                {
                    groups = JsonSerializer.Deserialize<Dictionary<string, Group>>(fs);
                }
        }

        public List<Group> Search(string text)
        {
            List<Group> result = new();
            foreach (var group in groups.Values)
            {
                if (group.Name.Contains(text))
                    result.Add(group);
            }
            return result;
        }

        public bool Update(Group group)
        {
            if (!groups.ContainsKey(group.UID))
                return false;
            groups[group.UID] = group;
            Save();
            return true;
        }

        public Group Create()
        {
            Group newGroup = new Group { UID = Guid.NewGuid().ToString() };
            groups.Add(newGroup.UID, newGroup);
            return newGroup;
        }

        public bool Delete(Group group)
        {
            if (!groups.ContainsKey(group.UID))
                return false;
            groups.Remove(group.UID);
            Save();
            return true;
        }

        void Save()
        {
            // save file (json) 
            using (FileStream fs = new FileStream("group.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, groups);
            }
        }
    }

}
