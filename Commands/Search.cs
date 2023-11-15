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
            Console.WriteLine("поиск чурки");
            List<Student> students = studentDB.Search(Console.ReadLine());
            for (int j =  0; j < students.Count; j++) 
            {
                Console.WriteLine($"{students[j].LastName}{students[j].FirstName}{students[j].UID} ");
            }
        }
    }
}

