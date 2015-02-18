using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Duck myDuck = new MallardDuck();

            myDuck.setFlyBehaviour(new FlyWithWings());
            myDuck.performFly();
            myDuck.setFlyBehaviour(new FlyNoWay());
            myDuck.performFly();
            myDuck.setFlyBehaviour(new FlyRocket());
            myDuck.performFly();
        }
    }
}
