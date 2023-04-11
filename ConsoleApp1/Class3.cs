using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Train : TS
    {
        public string colour { get; set; }
        public string vagoni { get; set; }

        public override void Move()
        {
            Console.WriteLine("Поезд двигается");
        }
    }
}
