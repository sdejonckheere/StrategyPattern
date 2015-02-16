using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyWithWings : IFlyable
    {
        public void fly()
        {
            System.Diagnostics.Debug.WriteLine("Iam flying!");
        }
    }
}
