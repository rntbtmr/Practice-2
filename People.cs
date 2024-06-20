using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace WindowsFormApp
{
    class People
    {
        public int x { get; set; }
        public int y { get; set; }
        private static int r = 10;
        public Brush brush;
        public Timer movementTimer;
        public bool flagInfection; 

        public People(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.brush = Brushes.Gray;
            this.flagInfection = false;
        }

        public void Move(int dx, int dy, int Width, int Height)
        {
            this.x = Math.Max(r, Math.Min(Width - r, this.x + dx));
            this.y = Math.Max(r, Math.Min(Height - r, this.y + dy));
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(brush, this.x, this.y, r, r);
        }

        public void StartRandomMovement(int interval, int Width, int Height, Form form)
        {
            if (movementTimer == null)
            {
                movementTimer = new Timer();
                movementTimer.Interval = interval;
                movementTimer.Elapsed += (sender, e) =>
                {
                    RandomMove(Width, Height);
                    form.Invalidate();
                };
                movementTimer.Start();
            }
        }

        public void RandomMove(int Width, int Height)
        {
            Random random = new Random();
            int dx = random.Next(-1, 2);
            int dy = random.Next(-1, 2); 
            Move(dx, dy, Width, Height);
        }

        public int getDistance(int x1, int y1)
        {
            int distance;
            distance = System.Convert.ToInt32(Math.Sqrt(((x1 - x) * (x1 - x)) + ((y1 - y) * (y1 - y))));
            return distance;
        }
    }
}
