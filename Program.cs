using System.Xml.Linq;
using ConsoleApp5.Commands;
using ConsoleApp5.DB;
using Microsoft.VisualBasic.FileIO;
class Program
{
    public static void Main()
    {  
        CommandManager commandManager = new CommandManager();
        StudentDB studentDB = new StudentDB();
        GroupDB groupDB = new GroupDB();
        commandManager.RegisterCommand("Create student", new CommandCreateStudent(studentDB));
        commandManager.RegisterCommand("Search student", new Search(studentDB));// Search - поиск студентов по имени/фамилии, должен выводиться UID
        commandManager.RegisterCommand("Edit student", new Edit(studentDB));// Edit - редактирование выбранного студента
        commandManager.RegisterCommand("Create group", new CommandCreateGroup(groupDB));
        commandManager.RegisterCommand("Delete group", new CommandDeleteGroup(groupDB));


        commandManager.Start();
    }

}
