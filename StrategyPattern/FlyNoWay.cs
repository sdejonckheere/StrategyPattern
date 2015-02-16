using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyNoWay : IFlyable
    {

        public void fly()
        {
            System.Diagnostics.Debug.WriteLine("I cant fly :(");
        }
    }
}
