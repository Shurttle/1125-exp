using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Commands
{
  
    
        internal class CommandsEdit : CommandStudent
        {
            private StudentDB studentDB;
            public CommandsEdit(StudentDB studentDB)
            {
                this.studentDB = studentDB;
            }
            public override void Execute()
            {

                Console.WriteLine("Редактирование студента");
                List<Student> students = studentDB.Search("");
                int k = 0;
                foreach (var item in students)
                {
                    Console.WriteLine($"{k++}) {item.FirstName}{item.LastName}");
                }
                Console.WriteLine("Введите номер чурки");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Новое имя чурки?");
                students[id].FirstName = Console.ReadLine();
                Console.WriteLine("Новая фамилия чурки?");
                students[id].LastName = Console.ReadLine();
                if (studentDB.Update(students[id]))
                {
                    Console.WriteLine("Изменения успешны");
                }


                else
                    Console.WriteLine("Произошла ошибка");
            }
        }
    }
