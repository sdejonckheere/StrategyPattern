using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            System.Diagnostics.Debug.WriteLine("Iam flying!");
        }
   
    }
}
