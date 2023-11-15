using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Commands
{
     class Search : CommandStudent
    {
        private StudentDB studentDB;
        public Search(StudentDB studentDB)
        {
            this.studentDB = studentDB;
        }
        public override void Execute()
        {
            Console.WriteLine("Поиск студента...");
            Console.WriteLine("Введите номер студента:");
            String id = Console.ReadLine();
            List<Student> students = studentDB.Search(id);
        }
    }
}

