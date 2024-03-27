using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            
            //Product product = new Product(9,"Güler");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());


            employeeManager.Add();


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager()
        {

        }
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine($"Listed  {_count}");
        }

        public void Add()
        {
            Console.WriteLine($"Added {_count}");
        }
    }

    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Employee added");
        }
    }

}
