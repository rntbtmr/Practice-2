using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Security.Cryptography.Xml;

namespace WindowsFormApp
{
    class People
    {
        public int x { get; set; }
        public int y { get; set; }
        public static int r = 10;
        public Brush brush;
        public Timer movementTimer;
        public bool flagInfection;
        public bool flagDeath;
        public bool flagRecovered;
        public int timeIncubation;
        private int dx;
        private int dy;

        public People(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.brush = Brushes.MediumSeaGreen;
            this.flagInfection = false;
            this.flagDeath = false;
            this.flagRecovered = false;
            this.timeIncubation = 0;
            Random random = new Random();
            this.dx = random.Next(-1, 2);
            this.dy = random.Next(-1, 2);
            if (dx == 0 && dy == 0) // To avoid zero direction
            {
                dx = 1;
            }
        }

        public void Move()
        {
            this.x += dx;
            this.y += dy;
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
            Move();
            CheckCollision(Width, Height);
        }

        private void CheckCollision(int Width, int Height)
        {
            if (x <= r || x >= Width - r)
            {
                dx = -dx;
            }
            if (y <= r || y >= Height - r)
            {
                dy = -dy;
            }
        }

        public int getDistance(int x1, int y1)
        {
            int distance;
            distance = Convert.ToInt32(Math.Sqrt(((x1 - x) * (x1 - x)) + ((y1 - y) * (y1 - y))));
            return distance;
        }
    }
}
