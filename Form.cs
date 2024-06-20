using System.Windows.Forms.VisualStyles;

namespace WindowsFormApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int time;
        List<People> peoples = new List<People>();
        Graphics g;

        public Form()
        {
            InitializeComponent();

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (this.button_start.Text == "Ќачать симул€цию")
            {
                this.button_start.Text = "ќстановить симул€цию";

                this.label.Visible = false;
                this.trackBarCapacity.Visible = false;
                this.textBoxCapacity.Visible = false;

                this.label2.Visible = false;
                this.trackBarDeath.Visible = false;
                this.textBoxDeath.Visible = false;

                this.label3.Visible = false;
                this.trackBarFrequency.Visible = false;
                this.textBoxFrequency.Visible = false;

                this.label4.Visible = false;
                this.trackBarStrictness.Visible = false;
                this.textBoxStrictness.Visible = false;

                this.label5.Visible = false;
                this.trackBarContacts.Visible = false;
                this.textBoxContacts.Visible = false;

                this.label6.Visible = false;
                this.trackBarRadius.Visible = false;
                this.textBoxRadius.Visible = false;

                this.TimerSimulation.Visible = true;

                this.label_stats.Visible = true;

                this.label_recovered.Visible = true;
                this.label_recoveredCount.Visible = true;

                this.label_patients.Visible = true;
                this.label_patientsCount.Visible = true;

                this.label_healthy.Visible = true;
                this.label_healthyCount.Visible = true;

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

                this.label_stats.Visible = false;

                this.label_recovered.Visible = false;
                this.label_recoveredCount.Visible = false;

                this.label_patients.Visible = false;
                this.label_patientsCount.Visible = false;

                this.label_healthy.Visible = false;
                this.label_healthyCount.Visible = false;

                this.label.Visible = true;
                this.trackBarCapacity.Visible = true;
                this.textBoxCapacity.Visible = true;

                this.label2.Visible = true;
                this.trackBarDeath.Visible = true;
                this.textBoxDeath.Visible = true;

                this.label3.Visible = true;
                this.trackBarFrequency.Visible = true;
                this.textBoxFrequency.Visible = true;

                this.label4.Visible = true;
                this.trackBarStrictness.Visible = true;
                this.textBoxStrictness.Visible = true;

                this.label5.Visible = true;
                this.trackBarContacts.Visible = true;
                this.textBoxContacts.Visible = true;

                this.label6.Visible = true;
                this.trackBarRadius.Visible = true;
                this.textBoxRadius.Visible = true;

                this.TimerSimulation.Visible = false;

                timer.Stop();

                foreach (People pl in peoples)
                {
                    pl.movementTimer.Stop();
                    pl.movementTimer = null;

                }

                this.Paint -= new PaintEventHandler(this.Form_Paint);
                g.Clear(Color.White);
            }
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (People pl in peoples)
            {
                pl.Draw(g);
            }
        }


        private void Form_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Random rnd = new Random();
            int x, y;
            for (int i = 0; i < 100; i++)
            {
                x = rnd.Next(40, ClientSize.Width - 340);
                y = rnd.Next(40, ClientSize.Height - 40);
                People pl = new People(x, y);
                peoples.Add(pl);
            }
            peoples[0].flagInfection = true;
            peoples[0].brush = Brushes.Red;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            TimerSimulation.Text = time.ToString();
            Logic();
            TimerSimulation.Refresh();
        }

        private void Logic()
        {
            for (int i = 0; i < peoples.Count; i++)
            {
                for (int j = i + 1; j < peoples.Count; j++)
                {
                    if (peoples[i].getDistance(peoples[j].x, peoples[j].y) < 70)
                    {
                        if (peoples[i].flagInfection && !peoples[j].flagInfection)
                        {
                            peoples[j].flagInfection = true;
                            peoples[j].brush = Brushes.Red;
                        }
                        else if (peoples[j].flagInfection && !peoples[i].flagInfection)
                        {
                            peoples[i].flagInfection = true;
                            peoples[i].brush = Brushes.Red;
                        }
                    }
                }
            }
        }
    }
}