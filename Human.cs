using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace WindowsFormApp
{
    abstract class Human
    {
        public int x { get; set; }
        public int y { get; set; }
        public static int r = 10;
        public Brush brush;
        public Timer movementTimer;
        public int timeIncubation;
        public int immunity; // у каждого здорового объекта есть свой индивидуальный иммунитет
        public int dx;
        public int dy;

        public Human(int x, int y, Brush brush)
        {
            this.x = x;
            this.y = y;
            this.brush = brush;
            this.timeIncubation = 0;
            Random random = new Random();
            this.dx = random.Next(-1, 2);
            this.dy = random.Next(-1, 2);
            if (dx == 0 && dy == 0) // To avoid zero direction
            {
                dx = 1;
            }
        }

        public Human(int x, int y, int dx, int dy, Brush brush)
        {
            this.x = x;
            this.y = y;
            this.brush = brush;
            this.timeIncubation = 0;
            this.dx = dx;
            this.dy = dy;
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
                    Move();
                    CheckCollision(Width, Height);
                    form.Invalidate();
                };
                movementTimer.Start();
            }
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

        // метод нахождения дистанции от одного объекта до другого
        public int getDistance(int x1, int y1)
        {
            int distance;
            distance = Convert.ToInt32(Math.Sqrt(((x1 - x) * (x1 - x)) + ((y1 - y) * (y1 - y))));
            return distance;
        }
    }
}
