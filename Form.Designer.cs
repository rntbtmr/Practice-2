namespace WindowsFormApp
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            trackBarDeath = new TrackBar();
            label2 = new Label();
            trackBarProbability = new TrackBar();
            label3 = new Label();
            trackBarIncubation = new TrackBar();
            label4 = new Label();
            trackBarAmount = new TrackBar();
            label5 = new Label();
            trackBarRadius = new TrackBar();
            label6 = new Label();
            button_start = new Button();
            textBoxDeath = new TextBox();
            textBoxProbability = new TextBox();
            textBoxIncubation = new TextBox();
            textBoxAmount = new TextBox();
            textBoxRadius = new TextBox();
            label_stats = new Label();
            label_healthy = new Label();
            label_patients = new Label();
            label10 = new Label();
            label_recovered = new Label();
            label_recoveredCount = new Label();
            label_patientsCount = new Label();
            label_healthyCount = new Label();
            timer = new System.Windows.Forms.Timer(components);
            TimerSimulation = new Label();
            label_deadCount = new Label();
            label_dead = new Label();
            label_infectedCount = new Label();
            label_infected = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarDeath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarProbability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIncubation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRadius).BeginInit();
            SuspendLayout();
            // 
            // trackBarDeath
            // 
            trackBarDeath.Location = new Point(915, 144);
            trackBarDeath.Margin = new Padding(3, 4, 3, 4);
            trackBarDeath.Maximum = 100;
            trackBarDeath.Name = "trackBarDeath";
            trackBarDeath.Size = new Size(227, 56);
            trackBarDeath.TabIndex = 3;
            trackBarDeath.TickFrequency = 10;
            trackBarDeath.Scroll += trackBarDeath_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(950, 115);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 2;
            label2.Text = "Входная смертность";
            // 
            // trackBarProbability
            // 
            trackBarProbability.Location = new Point(915, 229);
            trackBarProbability.Margin = new Padding(3, 4, 3, 4);
            trackBarProbability.Maximum = 100;
            trackBarProbability.Name = "trackBarProbability";
            trackBarProbability.Size = new Size(227, 56);
            trackBarProbability.TabIndex = 5;
            trackBarProbability.TickFrequency = 10;
            trackBarProbability.Scroll += trackBarProbability_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(942, 200);
            label3.Name = "label3";
            label3.Size = new Size(215, 23);
            label3.TabIndex = 4;
            label3.Text = "Вероятность заражения";
            // 
            // trackBarIncubation
            // 
            trackBarIncubation.Location = new Point(915, 316);
            trackBarIncubation.Margin = new Padding(3, 4, 3, 4);
            trackBarIncubation.Maximum = 14;
            trackBarIncubation.Name = "trackBarIncubation";
            trackBarIncubation.Size = new Size(227, 56);
            trackBarIncubation.TabIndex = 7;
            trackBarIncubation.TickFrequency = 2;
            trackBarIncubation.Scroll += trackBarIncubation_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(933, 287);
            label4.Name = "label4";
            label4.Size = new Size(221, 23);
            label4.TabIndex = 6;
            label4.Text = "Инкубационный период";
            // 
            // trackBarAmount
            // 
            trackBarAmount.Location = new Point(915, 403);
            trackBarAmount.Margin = new Padding(3, 4, 3, 4);
            trackBarAmount.Maximum = 200;
            trackBarAmount.Minimum = 50;
            trackBarAmount.Name = "trackBarAmount";
            trackBarAmount.Size = new Size(227, 56);
            trackBarAmount.TabIndex = 9;
            trackBarAmount.TickFrequency = 20;
            trackBarAmount.Value = 50;
            trackBarAmount.Scroll += trackBarAmount_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(961, 373);
            label5.Name = "label5";
            label5.Size = new Size(186, 23);
            label5.TabIndex = 8;
            label5.Text = "Количество человек";
            // 
            // trackBarRadius
            // 
            trackBarRadius.Location = new Point(915, 491);
            trackBarRadius.Margin = new Padding(3, 4, 3, 4);
            trackBarRadius.Maximum = 100;
            trackBarRadius.Name = "trackBarRadius";
            trackBarRadius.Size = new Size(227, 56);
            trackBarRadius.TabIndex = 11;
            trackBarRadius.TickFrequency = 10;
            trackBarRadius.Scroll += trackBarRadius_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(959, 461);
            label6.Name = "label6";
            label6.Size = new Size(165, 23);
            label6.TabIndex = 10;
            label6.Text = "Радиус заражения";
            // 
            // button_start
            // 
            button_start.BackColor = SystemColors.HotTrack;
            button_start.FlatStyle = FlatStyle.Flat;
            button_start.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_start.ForeColor = SystemColors.Control;
            button_start.Location = new Point(915, 553);
            button_start.Margin = new Padding(3, 4, 3, 4);
            button_start.Name = "button_start";
            button_start.Size = new Size(307, 52);
            button_start.TabIndex = 12;
            button_start.Text = "Начать симуляцию";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // textBoxDeath
            // 
            textBoxDeath.BorderStyle = BorderStyle.None;
            textBoxDeath.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDeath.Location = new Point(1150, 144);
            textBoxDeath.Margin = new Padding(3, 4, 3, 4);
            textBoxDeath.Name = "textBoxDeath";
            textBoxDeath.Size = new Size(73, 21);
            textBoxDeath.TabIndex = 14;
            textBoxDeath.Text = "0";
            textBoxDeath.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxProbability
            // 
            textBoxProbability.BorderStyle = BorderStyle.None;
            textBoxProbability.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProbability.Location = new Point(1150, 229);
            textBoxProbability.Margin = new Padding(3, 4, 3, 4);
            textBoxProbability.Name = "textBoxProbability";
            textBoxProbability.Size = new Size(73, 21);
            textBoxProbability.TabIndex = 15;
            textBoxProbability.Text = "0";
            textBoxProbability.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxIncubation
            // 
            textBoxIncubation.BorderStyle = BorderStyle.None;
            textBoxIncubation.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIncubation.Location = new Point(1150, 316);
            textBoxIncubation.Margin = new Padding(3, 4, 3, 4);
            textBoxIncubation.Name = "textBoxIncubation";
            textBoxIncubation.Size = new Size(73, 21);
            textBoxIncubation.TabIndex = 16;
            textBoxIncubation.Text = "0";
            textBoxIncubation.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmount.Location = new Point(1150, 403);
            textBoxAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(73, 21);
            textBoxAmount.TabIndex = 17;
            textBoxAmount.Text = "50";
            textBoxAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRadius
            // 
            textBoxRadius.BorderStyle = BorderStyle.None;
            textBoxRadius.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRadius.Location = new Point(1150, 491);
            textBoxRadius.Margin = new Padding(3, 4, 3, 4);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(73, 21);
            textBoxRadius.TabIndex = 18;
            textBoxRadius.Text = "0";
            textBoxRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // label_stats
            // 
            label_stats.AutoSize = true;
            label_stats.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_stats.Location = new Point(1049, 53);
            label_stats.Name = "label_stats";
            label_stats.Size = new Size(121, 27);
            label_stats.TabIndex = 19;
            label_stats.Text = "Статистика";
            label_stats.Visible = false;
            // 
            // label_healthy
            // 
            label_healthy.AutoSize = true;
            label_healthy.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_healthy.Location = new Point(985, 280);
            label_healthy.Name = "label_healthy";
            label_healthy.Size = new Size(95, 23);
            label_healthy.TabIndex = 20;
            label_healthy.Text = "Здоровых";
            label_healthy.Visible = false;
            // 
            // label_patients
            // 
            label_patients.AutoSize = true;
            label_patients.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_patients.Location = new Point(985, 199);
            label_patients.Name = "label_patients";
            label_patients.Size = new Size(84, 23);
            label_patients.TabIndex = 21;
            label_patients.Text = "Больных";
            label_patients.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(991, 283);
            label10.Name = "label10";
            label10.Size = new Size(0, 23);
            label10.TabIndex = 22;
            // 
            // label_recovered
            // 
            label_recovered.AutoSize = true;
            label_recovered.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_recovered.Location = new Point(985, 120);
            label_recovered.Name = "label_recovered";
            label_recovered.Size = new Size(150, 23);
            label_recovered.TabIndex = 23;
            label_recovered.Text = "Выздоровевших";
            label_recovered.Visible = false;
            // 
            // label_recoveredCount
            // 
            label_recoveredCount.AutoSize = true;
            label_recoveredCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_recoveredCount.Location = new Point(1165, 120);
            label_recoveredCount.Name = "label_recoveredCount";
            label_recoveredCount.Size = new Size(20, 23);
            label_recoveredCount.TabIndex = 24;
            label_recoveredCount.Text = "0";
            label_recoveredCount.TextAlign = ContentAlignment.MiddleRight;
            label_recoveredCount.Visible = false;
            // 
            // label_patientsCount
            // 
            label_patientsCount.AutoSize = true;
            label_patientsCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_patientsCount.Location = new Point(1165, 199);
            label_patientsCount.Name = "label_patientsCount";
            label_patientsCount.Size = new Size(20, 23);
            label_patientsCount.TabIndex = 25;
            label_patientsCount.Text = "0";
            label_patientsCount.TextAlign = ContentAlignment.MiddleRight;
            label_patientsCount.Visible = false;
            // 
            // label_healthyCount
            // 
            label_healthyCount.AutoSize = true;
            label_healthyCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_healthyCount.Location = new Point(1165, 280);
            label_healthyCount.Name = "label_healthyCount";
            label_healthyCount.Size = new Size(20, 23);
            label_healthyCount.TabIndex = 26;
            label_healthyCount.Text = "0";
            label_healthyCount.TextAlign = ContentAlignment.MiddleRight;
            label_healthyCount.Visible = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // TimerSimulation
            // 
            TimerSimulation.AutoSize = true;
            TimerSimulation.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimerSimulation.Location = new Point(1168, 12);
            TimerSimulation.Name = "TimerSimulation";
            TimerSimulation.Size = new Size(24, 27);
            TimerSimulation.TabIndex = 27;
            TimerSimulation.Text = "0";
            TimerSimulation.Visible = false;
            // 
            // label_deadCount
            // 
            label_deadCount.AutoSize = true;
            label_deadCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_deadCount.Location = new Point(1165, 352);
            label_deadCount.Name = "label_deadCount";
            label_deadCount.Size = new Size(20, 23);
            label_deadCount.TabIndex = 29;
            label_deadCount.Text = "0";
            label_deadCount.TextAlign = ContentAlignment.MiddleRight;
            label_deadCount.Visible = false;
            // 
            // label_dead
            // 
            label_dead.AutoSize = true;
            label_dead.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_dead.Location = new Point(985, 352);
            label_dead.Name = "label_dead";
            label_dead.Size = new Size(88, 23);
            label_dead.TabIndex = 28;
            label_dead.Text = "Мертвых";
            label_dead.Visible = false;
            // 
            // label_infectedCount
            // 
            label_infectedCount.AutoSize = true;
            label_infectedCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_infectedCount.Location = new Point(1165, 423);
            label_infectedCount.Name = "label_infectedCount";
            label_infectedCount.Size = new Size(20, 23);
            label_infectedCount.TabIndex = 31;
            label_infectedCount.Text = "0";
            label_infectedCount.TextAlign = ContentAlignment.MiddleRight;
            label_infectedCount.Visible = false;
            // 
            // label_infected
            // 
            label_infected.AutoSize = true;
            label_infected.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_infected.Location = new Point(985, 423);
            label_infected.Name = "label_infected";
            label_infected.Size = new Size(117, 23);
            label_infected.TabIndex = 30;
            label_infected.Text = "Зараженных";
            label_infected.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(942, 53);
            label1.Name = "label1";
            label1.Size = new Size(237, 27);
            label1.TabIndex = 32;
            label1.Text = "Настройки симуляции";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1234, 620);
            Controls.Add(label1);
            Controls.Add(label_infectedCount);
            Controls.Add(label_infected);
            Controls.Add(label_deadCount);
            Controls.Add(label_dead);
            Controls.Add(TimerSimulation);
            Controls.Add(label_healthyCount);
            Controls.Add(label_patientsCount);
            Controls.Add(label_recoveredCount);
            Controls.Add(label_recovered);
            Controls.Add(label10);
            Controls.Add(label_patients);
            Controls.Add(label_healthy);
            Controls.Add(label_stats);
            Controls.Add(textBoxRadius);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxIncubation);
            Controls.Add(textBoxProbability);
            Controls.Add(textBoxDeath);
            Controls.Add(button_start);
            Controls.Add(trackBarRadius);
            Controls.Add(label6);
            Controls.Add(trackBarAmount);
            Controls.Add(label5);
            Controls.Add(trackBarIncubation);
            Controls.Add(label4);
            Controls.Add(trackBarProbability);
            Controls.Add(label3);
            Controls.Add(trackBarDeath);
            Controls.Add(label2);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1252, 667);
            MinimumSize = new Size(1252, 667);
            Name = "Form";
            Text = "Симуляция эпидемии";
            ((System.ComponentModel.ISupportInitialize)trackBarDeath).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarProbability).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIncubation).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRadius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarDeath;
        private Label label2;
        private TrackBar trackBarProbability;
        private Label label3;
        private TrackBar trackBarIncubation;
        private Label label4;
        private TrackBar trackBarAmount;
        private Label label5;
        private TrackBar trackBarRadius;
        private Label label6;
        private Button button_start;
        private TextBox textBoxDeath;
        private TextBox textBoxProbability;
        private TextBox textBoxIncubation;
        private TextBox textBoxAmount;
        private TextBox textBoxRadius;
        private Label label_stats;
        private Label label_healthy;
        private Label label_patients;
        private Label label10;
        private Label label_recovered;
        private Label label_recoveredCount;
        private Label label_patientsCount;
        private Label label_healthyCount;
        private System.Windows.Forms.Timer timer;
        private Label TimerSimulation;
        private Label label_deadCount;
        private Label label_dead;
        private Label label_infectedCount;
        private Label label_infected;
        private Label label1;
    }
}