using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim1
{
    public class Szef
    {
        private Symulacja symulacja;

        public Szef(Symulacja symulacja)
        {
            this.symulacja = symulacja;
            symulacja.list_osob += Print;
        }

        public void Print(string message)
        {
            Console.WriteLine("Szef: " + message);
        }
    }
}
