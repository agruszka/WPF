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
                    _listOsob(CurrentTime.ToString());
                    RaiseEventonCurrentTime(CurrentTime.ToString());
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
