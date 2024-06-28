using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace WindowsFormApp
    {
    class Hospital
    {
        public int x { get; set; }
        public int y { get; set; }
        public Brush brush;

        public Hospital(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.brush = Brushes.Blue;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(brush, this.x, this.y, 100, 50);
        }

    }
}
