using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            InterfacePerson student = new Student();

            student.Name = "Güler";
            student.PrintInfo();


            Teacher teacher = new Teacher { Name = "Mehmet" };
            teacher.PrintInfo();

            Console.ReadLine();
        }
    }
}
