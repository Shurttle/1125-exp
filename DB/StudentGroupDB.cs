//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

using System.Text.Json;

namespace ConsoleApp5.DB
{
class StudentGroupDB
    {
        Dictionary<string, string> groupsToStudent = new Dictionary<string, string>();
        Dictionary<string, List<string>> studentsToGroup = new Dictionary<string, List<string>>();        
        private StudentDB studentDB;
        private GroupDB groupDB;
        public StudentGroupDB(StudentDB studentDB, GroupDB groupDB)
        {
            this.studentDB = studentDB;
            this.groupDB = groupDB;
        }
        public void ConnectToGroup(Student student, Group group)
        {
            groupsToStudent.Add(student.UID, group.UID);
            if (studentsToGroup.ContainsKey(student.UID))
            {
                studentsToGroup[group.UID].Add(student.UID);
            }
            else
            {
                studentsToGroup.Add(group.UID, new List<string> { student.UID });
            }
        }
            public Group GetGroup(Student student)
            {
            string UIDgroup = groupsToStudent[student.UID];
            List<Group> groupList = groupDB.Search("");
            foreach (var group in groupList)
            {
                
            }
        }
        }
    }
}

