using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    class Student : InterfacePerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }
}
