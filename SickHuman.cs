using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    class SickHuman : Human
    {
        public SickHuman(int x, int y, int dx, int dy) : base(x, y, dx, dy, Brushes.Red) { }

        public SickHuman(int x, int y) : base(x, y, Brushes.Red) { }
    }
}
