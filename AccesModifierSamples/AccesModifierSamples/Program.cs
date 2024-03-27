using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifierSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Güler";
            student.Save();

            Console.ReadLine();
        }
    }

    public class Person
    {
        protected int Id { get; set; }
        public string name { get; set; }
    }

    public class Student : Person
    {
        public Student()
        {
            this.Id = 9;
        }
        public void Save()
        {
            Console.WriteLine("name: {0} saved id is {1}",this.name,this.Id);
        }
    }


}
