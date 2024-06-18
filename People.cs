using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    class People
    {
        public int x { get; set; }
        public int y { get; set; }
        private static int r = 5;


        public People(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int dx, int dy, int Width, int Height)
        {
            this.x = Math.Max(0, Math.Min(Width - r, this.x + dx));
            this.y = Math.Max(0, Math.Min(Height - r, this.y + dy));
        }

        public void Draw (Graphics g)
        {
            g.FillEllipse(Brushes.Gray, this.x, this.y, r, r);
        }
    }
}
