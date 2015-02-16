using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
    
        public int MallardDuck{

            set { leeftijd = value; }

        }
        public void display(){

            System.Diagnostics.Debug.WriteLine("I am a real mallard duck!");

        }
    
    }
}
