using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MysqlServer mysqlServer = new MysqlServer();
            mysqlServer.Add();

            Console.ReadLine();
            
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Default added");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Default deleted");
        }
    }

    class SqlServer :Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL SERVER");
            //base.Add();
        }

        public override void Delete()
        {
            base.Delete();
        }
    }

    class MysqlServer :Database
    {

    }
}
