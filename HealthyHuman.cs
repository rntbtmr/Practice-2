using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    class HealthyHuman : Human 
    {
        public HealthyHuman(int x, int y) : base(x, y, Brushes.MediumSeaGreen) 
        { 
            Random random = new Random();
            this.immunity = random.Next(0, 50);
        }
    }
}
