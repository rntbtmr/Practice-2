using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    class RecoveredHuman : Human
    {
        public RecoveredHuman(int x, int y, int dx, int dy) : base(x, y, dx, dy, Brushes.Blue) { }
    }
}
