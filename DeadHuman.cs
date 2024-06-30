using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    internal class DeadHuman : Human
    {
        public DeadHuman(int x, int y) : base(x, y, Brushes.Gray) { }
    }
}
