using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    interface InterfacePerson
    {
        int Id { get; set; }
        string Name { get; set; }
        void PrintInfo();

    }
}
