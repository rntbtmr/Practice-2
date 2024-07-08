using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace WindowsFormApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int time; // поле дл подсчета времени симул€ции
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
                
                // создание объектов
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
                peoples[x] = new SickHuman(peoples[x].x, peoples[x].y);

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
            Random random = new Random();
            
            // проверка заражени€
            for (int i = 0; i < peoples.Count; i++)
            {
                for (int j = i + 1; j < peoples.Count; j++)
                {
                    if (peoples[i].getDistance(peoples[j].x, peoples[j].y) < trackBarRadius.Value + Human.r)
                    {
                        if (peoples[i] is SickHuman && peoples[j] is HealthyHuman)
                        {
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

            // проверка выздоровлени€ или смерти
            if (time % 50 == 0)
            {
                for (int i = 0; i < peoples.Count; i++)
                {
                    if (peoples[i] is SickHuman)
                    {
                        int probabilityDeath = random.Next(1, 101);
                        if (probabilityDeath <= trackBarDeath.Value)
                            peoples[i] = new DeadHuman(peoples[i].x, peoples[i].y);
                        else
                        {
                            peoples[i] = new RecoveredHuman(peoples[i].x, peoples[i].y, peoples[i].dx, peoples[i].dy);
                            peoples[i].StartRandomMovement(40, ClientSize.Width - 390, ClientSize.Height, this);
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
            int amountHealthy = 0, amountDeath = 0, amountPatient = 0, amountInfected = 0, amountRecovered = 0;
            time++;
            TimerSimulation.Text = Convert.ToString(time / 10);
            Logic();
            for (int i = 0; i < trackBarAmount.Value; i++)
            {
                if (peoples[i] is InfectedHuman)
                    peoples[i].timeIncubation++;

                // проверка инкубационного периода
                if (peoples[i].timeIncubation > trackBarIncubation.Value * 10)
                {
                    peoples[i] = new SickHuman(peoples[i].x, peoples[i].y, peoples[i].dx, peoples[i].dy);
                    peoples[i].StartRandomMovement(40, ClientSize.Width - 390, ClientSize.Height, this);
                }

                // подсчет статистики
                if (peoples[i] is SickHuman)
                    amountPatient++;

                if (peoples[i] is DeadHuman) amountDeath++;

                if (peoples[i] is HealthyHuman)
                    amountHealthy++;

                if (peoples[i] is RecoveredHuman)
                    amountRecovered++;

                if (peoples[i] is InfectedHuman)
                    amountInfected++;

            }

            label_healthyCount.Text = Convert.ToString(amountHealthy);
            label_patientsCount.Text = Convert.ToString(amountPatient);
            label_deadCount.Text = Convert.ToString(amountDeath);
            label_recoveredCount.Text = Convert.ToString(amountRecovered);
            label_infectedCount.Text = Convert.ToString(amountInfected);

            TimerSimulation.Refresh();
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
            this.label1.Visible = !visible;

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

            this.label_dead.Visible = visible;
            this.label_deadCount.Visible = visible;

            this.label_infected.Visible = visible;
            this.label_infectedCount.Visible = visible;
        }
    }
}