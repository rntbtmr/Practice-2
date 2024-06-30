using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    class InfectedHuman : Human
    {
        public InfectedHuman(int x, int y, int dx, int dy) : base(x, y, dx, dy, Brushes.Pink) { }

        public InfectedHuman(int x, int y) : base(x, y, Brushes.Pink) { }
    }
}
