//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

using ConsoleApp5.DB;
using System;
using System.ComponentModel.DataAnnotations;

class StudentGroupDB
{
    private StudentDB studentDB;
    private GroupDB groupDB;

    private Dictionary<string, string> studentGroupMap;
    private Dictionary<string, List<string>> groupStudentMap;

    public StudentGroupDB(StudentDB studentDB, GroupDB groupDB)
    {
        this.studentDB = studentDB;
        this.groupDB = groupDB;
        studentGroupMap = new Dictionary<string, string>();
        groupStudentMap = new Dictionary<string, List<string>>();
    }

    public void AddStudentToGroup()
    {
        Console.Write("Введите UID студента:\t");
        Student studentUID = studentDB.GetByID(Console.ReadLine());
        if (studentUID == null)
        {
            Console.WriteLine("Такого студента не существует! :(");
            return;
        }
        Console.Write("Введите UID студента:\t");
        Group groupUID = groupDB.GetByID(Console.ReadLine());
        if (groupUID == null)
        {
            Console.WriteLine("Такой группы не существует! :(");
            return;
        }
        if (!studentGroupMap.ContainsKey(studentUID.UID))
        {
            studentGroupMap.Add(studentUID.UID, groupUID.UID);
        }
        else
        {
            string uidG = studentGroupMap[studentUID.UID];
            groupStudentMap[uidG].Remove(studentUID.UID);
            studentGroupMap[studentUID.UID] = groupUID.UID;
        }
        if (!groupStudentMap.ContainsKey(groupUID.UID))
        {
            groupStudentMap.Add(groupUID.UID, new List<string>(new string[] { studentUID.UID }));
        }
        else
        {
            groupStudentMap[groupUID.UID].Add(studentUID.UID);
        }
    }
}