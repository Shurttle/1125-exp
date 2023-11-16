﻿using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
class StudentDB
{
    Dictionary<string, Student> students;

    public StudentDB()
    {
        if (!File.Exists("Json"))
        {
            students = new Dictionary<string, Student>();
        }
        else
            using (var file = File.OpenRead("Json"))
            {
                students = JsonSerializer.Deserialize<Dictionary<string, Student>>(file);
            }

    }

    public List<Student> Search(string text)
    {
        List<Student> result = new();
        foreach (var student in students.Values)
        {
            if (student.FirstName.Contains(text) ||
                    student.LastName.Contains(text))
                result.Add(student);
        }
        return result;
    }

    public bool Update(Student student)
    {
        if (!students.ContainsKey(student.UID))
            return false;
        students[student.UID] = student;
        Save();
        return true;
    }

    public Student Create()
    {
        Student newStudent = new Student { UID = Guid.NewGuid().ToString() };
        students.Add(newStudent.UID, newStudent);
        return newStudent;
    }

    public bool Delete(Student student)
    {
        if (!students.ContainsKey(student.UID))
            return false;
        students.Remove(student.UID);
        Save();
        return true;
    }



    void Save()
    {
        using (var fileJson = File.Create("Json"))
            JsonSerializer.Serialize(fileJson, students);
        
        // save file (json)
    }
}
