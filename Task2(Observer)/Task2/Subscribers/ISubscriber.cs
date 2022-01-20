using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Subscribers
{
    public interface ISubscriber
    {
        void GetNotify(double t, double p, double h);
    }
}
