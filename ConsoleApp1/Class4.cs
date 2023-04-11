using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Plane : TS
    {
        public string colour { get; set; }
        public string mesta { get; set; }

        public override void Move()
        {
            Console.WriteLine("Самолёт летит");
        }
    }
}
