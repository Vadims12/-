using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class ChocolateBoiler
    {
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }
        private static ChocolateBoiler boiler;
        private static object Lock = new object();
        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetBoiler()
        {
            if (boiler == null)
            {
                lock (Lock)
                {
                    boiler = new ChocolateBoiler();
                    {
                        if (boiler == null)
                        {
                            boiler = new ChocolateBoiler();
                        }
                    }
                }
            }
            return boiler;
        } 

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
            }
        }
        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
                Boiled = false;
            }
        }
        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
            }
        }     
    }
}
