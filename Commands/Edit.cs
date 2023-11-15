using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Commands
{
    class Edit : CommandStudent
    {
        private StudentDB studentDB;

        public Edit(StudentDB studentDB)
        {
            this.studentDB = studentDB;
        }
        public override void Execute()
        {
            Console.WriteLine("Редактирвание студента...");
            Console.WriteLine("Введите номер студента:");
            String id = Console.ReadLine(); 
            List<Student> students = studentDB.Search(id);
        }
    }
}
