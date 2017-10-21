using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaServera
{
    class Program
    {
        static void Main(string[] args)
        {

            Symulacja symulacja = new Symulacja();
            Admin admin = new Admin(symulacja);
            Boss boss = new Boss(symulacja);
            symulacja.OdpalSymulacje();

            Console.ReadKey();

        }
    }
}
