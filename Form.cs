using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace WindowsFormApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int time;
        private List<People> peoples = new List<People>();
        private List<People> deadPeoples = new List<People>();
        private Hospital hospital;
        private Graphics g;

        public Form()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (this.button_start.Text == "Ќачать симул€цию")
            {
                g = this.CreateGraphics();

                this.button_start.Text = "ќстановить симул€цию";

                toggleVisibility(true);

                Random rnd = new Random();
                int x, y;
                for (int i = 0; i < trackBarAmount.Value; i++)
                {
                    x = rnd.Next(40, ClientSize.Width - 390);
                    y = rnd.Next(40, ClientSize.Height - 40);
                    People pl = new People(x, y);
                    peoples.Add(pl);
                }
                x = rnd.Next(0, trackBarAmount.Value);
                peoples[x].brush = Brushes.Pink;

                timer.Start();

                foreach (People pl in peoples)
                {   
                    pl.StartRandomMovement(100, ClientSize.Width, ClientSize.Height, this);
                }
                this.Paint += new PaintEventHandler(this.Form_Paint);
            }
            else
            {
                this.button_start.Text = "Ќачать симул€цию";

                toggleVisibility(false);

                timer.Stop();

                time = 0;

                foreach (People pl in peoples)
                {
                    pl.movementTimer.Stop();
                    pl.movementTimer = null;

                }

                peoples.Clear();
                deadPeoples.Clear();

                this.Paint -= new PaintEventHandler(this.Form_Paint);

                Invalidate();
            }
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (People pl in peoples)
                pl.Draw(g);
            foreach (People pl in deadPeoples)
                pl.Draw(g);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int amountHealthy = 0, amountDeath = 0, amountPatient = 0;
            time++;
            TimerSimulation.Text = Convert.ToString(time/10);
            Logic();
            foreach (People pl in peoples)
            {
                if (pl.flagInfection == false)
                    amountHealthy++;
                else amountPatient++;

                if (pl.brush == Brushes.Pink)
                    pl.timeIncubation++;
                if (pl.timeIncubation > trackBarIncubation.Value * 10)
                {
                    pl.brush = Brushes.Red;
                    pl.flagInfection = true;
                }
            }
            label_healthyCount.Text = Convert.ToString(amountHealthy);
            label_patientsCount.Text = Convert.ToString(amountPatient);
            TimerSimulation.Refresh();
        }

        private void Logic()
        {
            for (int i = 0; i < peoples.Count; i++)
            {
                for (int j = i + 1; j < peoples.Count; j++)
                {
                    if (peoples[i].getDistance(peoples[j].x, peoples[j].y) < trackBarRadius.Value + People.r)
                    {
                        if (peoples[i].flagInfection && !peoples[j].flagInfection)
                        {
                            Random random = new Random();
                            int probability = random.Next(1, 101);
                            if (probability <= trackBarProbability.Value)
                                peoples[j].brush = Brushes.Pink;
                            
                        }
                        else if (peoples[j].flagInfection && !peoples[i].flagInfection)
                        {
                            Random random = new Random();
                            int probability = random.Next(1, 101);
                            if (probability <= trackBarProbability.Value)
                                peoples[i].brush = Brushes.Pink;
                        }
                    }
                    //if (time % 50 == 0)
                    //    if (peoples[i].flagInfection)
                    //    {
                    //        Random random = new Random();
                    //        int probabilityDeath = random.Next(1, 101);
                    //        if (probabilityDeath <= trackBarDeath.Value)
                    //        {
                    //            peoples[i].brush = Brushes.Gray;
                    //            peoples[i].flagDeath = true;
                    //        }
                    //    }
                    
                }
            }
        }

        private void trackBarCapacity_Scroll(object sender, EventArgs e)
        {
            textBoxCapacity.Text = trackBarCapacity.Value.ToString();
        }

        private void trackBarDeath_Scroll(object sender, EventArgs e)
        {
            textBoxDeath.Text = trackBarDeath.Value.ToString();
        }

        private void trackBarProbability_Scroll(object sender, EventArgs e)
        {
            textBoxProbability.Text = trackBarProbability.Value.ToString();
        }

        private void trackBarIncubation_Scroll(object sender, EventArgs e)
        {
            textBoxIncubation.Text = trackBarIncubation.Value.ToString();
        }

        private void trackBarAmount_Scroll(object sender, EventArgs e)
        {
            textBoxAmount.Text = trackBarAmount.Value.ToString();
        }

        private void trackBarRadius_Scroll(object sender, EventArgs e)
        {
            textBoxRadius.Text = trackBarRadius.Value.ToString();
        }

        private void toggleVisibility(bool visible)
        {
            this.label.Visible = !visible;
            this.trackBarCapacity.Visible = !visible;
            this.textBoxCapacity.Visible = !visible;

            this.label2.Visible = !visible;
            this.trackBarDeath.Visible = !visible;
            this.textBoxDeath.Visible = !visible;

            this.label3.Visible = !visible;
            this.trackBarProbability.Visible = !visible;
            this.textBoxProbability.Visible = !visible;

            this.label4.Visible = !visible;
            this.trackBarIncubation.Visible = !visible;
            this.textBoxIncubation.Visible = !visible;

            this.label5.Visible = !visible;
            this.trackBarAmount.Visible = !visible;
            this.textBoxAmount.Visible = !visible;

            this.label6.Visible = !visible;
            this.trackBarRadius.Visible = !visible;
            this.textBoxRadius.Visible = !visible;

            this.TimerSimulation.Visible = visible;

            this.label_stats.Visible = visible;

            this.label_recovered.Visible = visible;
            this.label_recoveredCount.Visible = visible;

            this.label_patients.Visible = visible;
            this.label_patientsCount.Visible = visible;

            this.label_healthy.Visible = visible;
            this.label_healthyCount.Visible = visible;
        }
    }
}