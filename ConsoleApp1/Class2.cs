using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto : TS
    {
        public string brand { get; set; }
        public string colour { get; set; }

        public override void Move()
        {
            Console.WriteLine("Авто едет");
        }
    }
}
