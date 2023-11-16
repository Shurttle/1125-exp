using ConsoleApp5.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Commands
{
    internal class CommandEditGroup : CommandStudent
    {
        private GroupDB groupDB;
        
        public CommandEditGroup(GroupDB groupDB)
        {
            this.groupDB = groupDB;
        }
        public override void Execute() 
        {
            Console.WriteLine("поиск аула");
            List<Group> groups = groupDB.Search(Console.ReadLine());
            for (int i = 0; i < groups.Count; i++) 
            {
                Console.WriteLine($"{groups[i].Name}{groups[i].UID}");
                Console.WriteLine("Что отредактировать?");
                int.TryParse(Console.ReadLine(), out int edit);
                if ((groups.Count > edit - 1))
                {
                    Console.WriteLine("укажите новое название аула");
                    groups[i].Name = Console.ReadLine();
                    if (groupDB.Update(groups[i]))
                        Console.WriteLine("аул переименован");
                }
                else
                    Console.WriteLine("нет такого аула");
            }
        }
    }
}
