using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyRocket : FlyBehavior
    {
        public void Fly()
        {
            System.Diagnostics.Debug.WriteLine("Rocketpower");
        }
    }
}
