using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesModifierSamples;

namespace ClassAccesSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            student.Save();

            Console.ReadLine();
        }
    }
}
