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
        commandManager.RegisterCommand("Search student", new CommandSearchStudent(studentDB));
        commandManager.RegisterCommand("Edit student", new CommandsEdit(studentDB));
        commandManager.RegisterCommand("Create group", new CommandCreateGroup(groupDB));
        commandManager.RegisterCommand("Delete group", new CommandDeleteGroup(groupDB));
        commandManager.RegisterCommand("Delete student", new CommandDeleteStudent(studentDB));
        commandManager.RegisterCommand("Search group", new CommandSearchGroup(groupDB));


        commandManager.Start();
    }

}
