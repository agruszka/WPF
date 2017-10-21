using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sim1
{
    public class Symulacja
    {
        public delegate void OnEventCurrentTimeIsEven(string msg);
        public OnEventCurrentTimeIsEven list_osob;
        public int CurrentTime;

        public Symulacja()
        {
            CurrentTime = 0;
        }

        public void OdpalSymulacje()
        {
            while (CurrentTime <10)
            {
                if (CurrentTime % 2 ==0)
                {
                    //Console.WriteLine("Parzysty");
                    list_osob(CurrentTime.ToString());
                }
                Thread.Sleep(1500);
                Console.WriteLine(CurrentTime);
                CurrentTime++;
            }
        }
    }
}
