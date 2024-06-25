using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    internal class Hospital
    {
        public int x;
        public int y;
        public Pen pen;

        public Hospital(int x, int y) {
            this.x = x;
            this.y = y;
            this.pen = Pens.Blue;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x, y, 50, 30);
        }
    }
}
