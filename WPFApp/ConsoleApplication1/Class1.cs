using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim1
{
    public class Pracownik
    {
        private Symulacja symulacja;

        public Pracownik(Symulacja symulacja)
        {
            this.symulacja = symulacja;
            symulacja.list_osob += Print;
        }

        public void Print(string message)
        {
            Console.WriteLine("Pracownik: " + message);
        }
    }
}
