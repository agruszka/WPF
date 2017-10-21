using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TemperaturaServera
{
    public class Symulacja
    {
        public delegate void OnEventCurrentTimeIsEven(string msg);
        public int CounterUser { get; set; }
        private OnEventCurrentTimeIsEven _listOsob;
        public event OnEventCurrentTimeIsEven list_osob

        {


            add
            {
                if (CounterUser <= 100)
                {
                    _listOsob += value;
                }
                CounterUser++;
            }


            remove
            {
                if (CounterUser <= 100)
                {
                    _listOsob += value;
                }
                CounterUser++;
            }


        }
        public int CurrentTime;
        private int Temperature;

        public Symulacja()
        {
            CurrentTime = 70;
        }

        public void OdpalSymulacje()
        {
            Random rnd = new Random();


            while (Temperature < 80)
                
            {
                Temperature = rnd.Next(75, 85);

                Console.WriteLine(Temperature);
                if (Temperature > 80)
                {
               
                    RaiseEventonCurrentTime(Temperature.ToString());
                }
                Thread.Sleep(1500);
                Console.WriteLine(CurrentTime);
                CurrentTime++;
            }
        }


        private void RaiseEventonCurrentTime(string msg)
        {
            _listOsob?.Invoke(msg);

        }
    }
}