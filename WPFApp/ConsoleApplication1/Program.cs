using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim1
{
    class Program
    {
        static void Main(string[] args)
        {

            Symulacja symulacja = new Symulacja();
            Pracownik pracownik = new Pracownik(symulacja);
            Szef szef = new Szef(symulacja);
            symulacja.OdpalSymulacje();

            Console.ReadKey();

        }
    }
}
