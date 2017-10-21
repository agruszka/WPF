using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaServera
{
    public class Admin
    {
        private Symulacja symulacja;

        public Admin(Symulacja symulacja)
        {
            this.symulacja = symulacja;
            symulacja.list_osob += Print;
        }

        public void Print(string message)
        {
            Console.WriteLine("Admin: " + message);
        }
    }
}