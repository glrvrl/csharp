using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            Console.ReadLine();
        }
    }

    class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
    internal interface ILogging
    {
        void Log();
    }
    class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Checked user");
        }
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class CustomerManager
    {
        private CrossCuttingConcersFacede _concert;
        public CustomerManager()
        {
            _concert = new CrossCuttingConcersFacede();
        }

        public void Save()
        {
            _concert.Logging.Log();
            _concert.Caching.Cache();
            _concert.Authorize.CheckUser();
            Console.WriteLine("Saved");
        }
    }

    class CrossCuttingConcersFacede
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;

        public CrossCuttingConcersFacede()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}
