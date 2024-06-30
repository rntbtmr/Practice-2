using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace WindowsFormApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int time;
        private List<Human> peoples = new List<Human>();
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
                    HealthyHuman hh = new HealthyHuman(x, y);
                    peoples.Add(hh);
                }
                x = rnd.Next(0, trackBarAmount.Value);
                SickHuman sh = new SickHuman(peoples[x].x, peoples[x].y);
                peoples[x] = sh;

                timer.Start();

                foreach (Human pl in peoples)
                {
                    pl.StartRandomMovement(40, ClientSize.Width - 390, ClientSize.Height, this);
                }
                this.Paint += new PaintEventHandler(this.Form_Paint);
            }
            else
            {
                this.button_start.Text = "Ќачать симул€цию";

                toggleVisibility(false);

                timer.Stop();

                time = 0;

                foreach (Human pl in peoples)
                {
                    pl.movementTimer.Stop();
                    pl.movementTimer = null;
                }

                peoples.Clear();

                this.Paint -= new PaintEventHandler(this.Form_Paint);

                Invalidate();
            }
        }

        private void Logic()
        {
            for (int i = 0; i < peoples.Count; i++)
            {
                for (int j = i + 1; j < peoples.Count; j++)
                {
                    if (peoples[i].getDistance(peoples[j].x, peoples[j].y) < trackBarRadius.Value + Human.r)
                    {
                        if (peoples[i] is SickHuman && peoples[j] is HealthyHuman)
                        {
                            Random random = new Random();
                            int probability = random.Next(1, 101);
                            if (probability <= trackBarProbability.Value)
                                if (probability > peoples[j].immunity)
                                {
                                    peoples[j] = new InfectedHuman(peoples[j].x, peoples[j].y, peoples[j].dx, peoples[j].dy);
                                    peoples[j].StartRandomMovement(40, ClientSize.Width - 390, ClientSize.Height, this);
                                }
                        }
                        else if (peoples[j] is SickHuman && peoples[i] is HealthyHuman)
                        {
                            Random random = new Random();
                            int probability = random.Next(1, 101);
                            if (probability <= trackBarProbability.Value)
                                if (probability > peoples[i].immunity)
                                {
                                    peoples[i] = new InfectedHuman(peoples[i].x, peoples[i].y, peoples[i].dx, peoples[i].dy);
                                    peoples[i].StartRandomMovement(40, ClientSize.Width - 390, ClientSize.Height, this);
                                }
                        }
                    }


                }
            }
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Human pl in peoples)
                pl.Draw(g);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int amountHealthy = 0, amountDeath = 0, amountPatient = 0;
            time++;
            TimerSimulation.Text = Convert.ToString(time/10);
            Logic();
            for (int i = 0; i < trackBarAmount.Value; i++)
            {
                if (peoples[i] is SickHuman)
                    amountPatient++;
                else amountHealthy++;

                if (peoples[i] is InfectedHuman)
                    peoples[i].timeIncubation++;
                if (peoples[i].timeIncubation > trackBarIncubation.Value * 10)
                {
                    peoples[i] = new SickHuman(peoples[i].x, peoples[i].y, peoples[i].dx, peoples[i].dy);
                    peoples[i].StartRandomMovement(40, ClientSize.Width - 390, ClientSize.Height, this);
                }
            }
            label_healthyCount.Text = Convert.ToString(amountHealthy);
            label_patientsCount.Text = Convert.ToString(amountPatient);
            TimerSimulation.Refresh();
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