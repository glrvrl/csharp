using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Database oracle = new Oracle();
            oracle.Add();
            oracle.Delete();

            Database sqlserver = new SqlServer();
            sqlserver.Add();
            sqlserver.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public abstract void Delete();
    }


    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SQLServer");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

}
