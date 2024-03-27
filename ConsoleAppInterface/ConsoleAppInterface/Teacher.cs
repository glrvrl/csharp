using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    class Teacher : InterfacePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Teacher : {Name}");
        }
    }
}
