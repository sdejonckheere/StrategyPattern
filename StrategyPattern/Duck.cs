using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Duck
    {

        public FlyBehavior FlyBehaviour;


        public void performFly()
        {

            FlyBehaviour.Fly();

        }

        public void Display()
        {

            System.Diagnostics.Debug.WriteLine("Displaying");

        }
        public void Swim()
        {

            System.Diagnostics.Debug.WriteLine("Swimming");

        }
        public void setFlyBehaviour(FlyBehavior i)
        {
            this.FlyBehaviour = i;
        }
      
    }
}
