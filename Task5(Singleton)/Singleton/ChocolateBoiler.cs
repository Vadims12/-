using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class ChocolateBoiler
    {
        private static ChocolateBoiler boiler;

        private static object syncFlag;

        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public ChocolateBoiler GetBoiler()
        {
            if (boiler == null)
            {
                lock (syncFlag)
                {
                    boiler = new ChocolateBoiler();
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
        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
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
    }
}
