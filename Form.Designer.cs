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
            label = new Label();
            trackBarCapacity = new TrackBar();
            trackBarDeath = new TrackBar();
            label2 = new Label();
            trackBarFrequency = new TrackBar();
            label3 = new Label();
            trackBarStrictness = new TrackBar();
            label4 = new Label();
            trackBarContacts = new TrackBar();
            label5 = new Label();
            trackBarRadius = new TrackBar();
            label6 = new Label();
            button_start = new Button();
            textBoxCapacity = new TextBox();
            textBoxDeath = new TextBox();
            textBoxFrequency = new TextBox();
            textBoxStrictness = new TextBox();
            textBoxContacts = new TextBox();
            textBoxRadius = new TextBox();
            label_stats = new Label();
            label_healthy = new Label();
            label_patients = new Label();
            label10 = new Label();
            label_recovered = new Label();
            label_recoveredCount = new Label();
            label_patientsCount = new Label();
            label_healthyCount = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDeath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarStrictness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRadius).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(824, 18);
            label.Name = "label";
            label.Size = new Size(153, 19);
            label.TabIndex = 0;
            label.Text = "Вместимость больниц";
            // 
            // trackBarCapacity
            // 
            trackBarCapacity.Location = new Point(801, 40);
            trackBarCapacity.Maximum = 100;
            trackBarCapacity.Name = "trackBarCapacity";
            trackBarCapacity.Size = new Size(199, 45);
            trackBarCapacity.TabIndex = 1;
            trackBarCapacity.TickFrequency = 10;
            // 
            // trackBarDeath
            // 
            trackBarDeath.Location = new Point(801, 108);
            trackBarDeath.Maximum = 100;
            trackBarDeath.Name = "trackBarDeath";
            trackBarDeath.Size = new Size(199, 45);
            trackBarDeath.TabIndex = 3;
            trackBarDeath.TickFrequency = 10;
            trackBarDeath.Value = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(831, 86);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 2;
            label2.Text = "Входная смертность";
            // 
            // trackBarFrequency
            // 
            trackBarFrequency.Location = new Point(801, 172);
            trackBarFrequency.Maximum = 100;
            trackBarFrequency.Name = "trackBarFrequency";
            trackBarFrequency.Size = new Size(199, 45);
            trackBarFrequency.TabIndex = 5;
            trackBarFrequency.TickFrequency = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(824, 150);
            label3.Name = "label3";
            label3.Size = new Size(158, 19);
            label3.TabIndex = 4;
            label3.Text = "Частота сомоизоляции";
            // 
            // trackBarStrictness
            // 
            trackBarStrictness.Location = new Point(801, 237);
            trackBarStrictness.Maximum = 100;
            trackBarStrictness.Name = "trackBarStrictness";
            trackBarStrictness.Size = new Size(199, 45);
            trackBarStrictness.TabIndex = 7;
            trackBarStrictness.TickFrequency = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(816, 215);
            label4.Name = "label4";
            label4.Size = new Size(171, 19);
            label4.TabIndex = 6;
            label4.Text = "Строгость самоизоляции";
            // 
            // trackBarContacts
            // 
            trackBarContacts.Location = new Point(801, 302);
            trackBarContacts.Maximum = 25;
            trackBarContacts.Name = "trackBarContacts";
            trackBarContacts.Size = new Size(199, 45);
            trackBarContacts.TabIndex = 9;
            trackBarContacts.TickFrequency = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(841, 280);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 8;
            label5.Text = "Контактов в день";
            // 
            // trackBarRadius
            // 
            trackBarRadius.Location = new Point(801, 368);
            trackBarRadius.Maximum = 20;
            trackBarRadius.Name = "trackBarRadius";
            trackBarRadius.Size = new Size(199, 45);
            trackBarRadius.TabIndex = 11;
            trackBarRadius.TickFrequency = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(839, 346);
            label6.Name = "label6";
            label6.Size = new Size(127, 19);
            label6.TabIndex = 10;
            label6.Text = "Радиус заражения";
            // 
            // button_start
            // 
            button_start.BackColor = SystemColors.HotTrack;
            button_start.FlatStyle = FlatStyle.Flat;
            button_start.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_start.ForeColor = SystemColors.Control;
            button_start.Location = new Point(801, 415);
            button_start.Name = "button_start";
            button_start.Size = new Size(269, 39);
            button_start.TabIndex = 12;
            button_start.Text = "Начать симуляцию";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.BorderStyle = BorderStyle.None;
            textBoxCapacity.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCapacity.Location = new Point(1006, 40);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Size = new Size(64, 17);
            textBoxCapacity.TabIndex = 13;
            textBoxCapacity.Text = "Число";
            textBoxCapacity.TextAlign = HorizontalAlignment.Center;
            textBoxCapacity.TextChanged += textBox1_TextChanged;
            // 
            // textBoxDeath
            // 
            textBoxDeath.BorderStyle = BorderStyle.None;
            textBoxDeath.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDeath.Location = new Point(1006, 108);
            textBoxDeath.Name = "textBoxDeath";
            textBoxDeath.Size = new Size(64, 17);
            textBoxDeath.TabIndex = 14;
            textBoxDeath.Text = "Число";
            textBoxDeath.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxFrequency
            // 
            textBoxFrequency.BorderStyle = BorderStyle.None;
            textBoxFrequency.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFrequency.Location = new Point(1006, 172);
            textBoxFrequency.Name = "textBoxFrequency";
            textBoxFrequency.Size = new Size(64, 17);
            textBoxFrequency.TabIndex = 15;
            textBoxFrequency.Text = "Число";
            textBoxFrequency.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStrictness
            // 
            textBoxStrictness.BorderStyle = BorderStyle.None;
            textBoxStrictness.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStrictness.Location = new Point(1006, 237);
            textBoxStrictness.Name = "textBoxStrictness";
            textBoxStrictness.Size = new Size(64, 17);
            textBoxStrictness.TabIndex = 16;
            textBoxStrictness.Text = "Число";
            textBoxStrictness.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxContacts
            // 
            textBoxContacts.BorderStyle = BorderStyle.None;
            textBoxContacts.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContacts.Location = new Point(1006, 302);
            textBoxContacts.Name = "textBoxContacts";
            textBoxContacts.Size = new Size(64, 17);
            textBoxContacts.TabIndex = 17;
            textBoxContacts.Text = "Число";
            textBoxContacts.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRadius
            // 
            textBoxRadius.BorderStyle = BorderStyle.None;
            textBoxRadius.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRadius.Location = new Point(1006, 368);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(64, 17);
            textBoxRadius.TabIndex = 18;
            textBoxRadius.Text = "Число";
            textBoxRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // label_stats
            // 
            label_stats.AutoSize = true;
            label_stats.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_stats.Location = new Point(923, 103);
            label_stats.Name = "label_stats";
            label_stats.Size = new Size(97, 21);
            label_stats.TabIndex = 19;
            label_stats.Text = "Статистика";
            label_stats.Visible = false;
            // 
            // label_healthy
            // 
            label_healthy.AutoSize = true;
            label_healthy.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_healthy.Location = new Point(867, 273);
            label_healthy.Name = "label_healthy";
            label_healthy.Size = new Size(74, 19);
            label_healthy.TabIndex = 20;
            label_healthy.Text = "Здоровых";
            label_healthy.Visible = false;
            // 
            // label_patients
            // 
            label_patients.AutoSize = true;
            label_patients.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_patients.Location = new Point(867, 212);
            label_patients.Name = "label_patients";
            label_patients.Size = new Size(65, 19);
            label_patients.TabIndex = 21;
            label_patients.Text = "Больных";
            label_patients.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(867, 212);
            label10.Name = "label10";
            label10.Size = new Size(0, 19);
            label10.TabIndex = 22;
            // 
            // label_recovered
            // 
            label_recovered.AutoSize = true;
            label_recovered.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_recovered.Location = new Point(867, 153);
            label_recovered.Name = "label_recovered";
            label_recovered.Size = new Size(114, 19);
            label_recovered.TabIndex = 23;
            label_recovered.Text = "Выздоровевших";
            label_recovered.Visible = false;
            // 
            // label_recoveredCount
            // 
            label_recoveredCount.AutoSize = true;
            label_recoveredCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_recoveredCount.Location = new Point(1024, 153);
            label_recoveredCount.Name = "label_recoveredCount";
            label_recoveredCount.Size = new Size(17, 19);
            label_recoveredCount.TabIndex = 24;
            label_recoveredCount.Text = "0";
            label_recoveredCount.TextAlign = ContentAlignment.MiddleRight;
            label_recoveredCount.Visible = false;
            // 
            // label_patientsCount
            // 
            label_patientsCount.AutoSize = true;
            label_patientsCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_patientsCount.Location = new Point(1024, 212);
            label_patientsCount.Name = "label_patientsCount";
            label_patientsCount.Size = new Size(17, 19);
            label_patientsCount.TabIndex = 25;
            label_patientsCount.Text = "0";
            label_patientsCount.TextAlign = ContentAlignment.MiddleRight;
            label_patientsCount.Visible = false;
            // 
            // label_healthyCount
            // 
            label_healthyCount.AutoSize = true;
            label_healthyCount.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_healthyCount.Location = new Point(1024, 273);
            label_healthyCount.Name = "label_healthyCount";
            label_healthyCount.Size = new Size(17, 19);
            label_healthyCount.TabIndex = 26;
            label_healthyCount.Text = "0";
            label_healthyCount.TextAlign = ContentAlignment.MiddleRight;
            label_healthyCount.Visible = false;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 475);
            Controls.Add(label_healthyCount);
            Controls.Add(label_patientsCount);
            Controls.Add(label_recoveredCount);
            Controls.Add(label_recovered);
            Controls.Add(label10);
            Controls.Add(label_patients);
            Controls.Add(label_healthy);
            Controls.Add(label_stats);
            Controls.Add(textBoxRadius);
            Controls.Add(textBoxContacts);
            Controls.Add(textBoxStrictness);
            Controls.Add(textBoxFrequency);
            Controls.Add(textBoxDeath);
            Controls.Add(textBoxCapacity);
            Controls.Add(button_start);
            Controls.Add(trackBarRadius);
            Controls.Add(label6);
            Controls.Add(trackBarContacts);
            Controls.Add(label5);
            Controls.Add(trackBarStrictness);
            Controls.Add(label4);
            Controls.Add(trackBarFrequency);
            Controls.Add(label3);
            Controls.Add(trackBarDeath);
            Controls.Add(label2);
            Controls.Add(trackBarCapacity);
            Controls.Add(label);
            Name = "Form";
            Text = "Симуляция эпидемии";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDeath).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarStrictness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRadius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TrackBar trackBarCapacity;
        private TrackBar trackBarDeath;
        private Label label2;
        private TrackBar trackBarFrequency;
        private Label label3;
        private TrackBar trackBarStrictness;
        private Label label4;
        private TrackBar trackBarContacts;
        private Label label5;
        private TrackBar trackBarRadius;
        private Label label6;
        private Button button_start;
        private TextBox textBoxCapacity;
        private TextBox textBoxDeath;
        private TextBox textBoxFrequency;
        private TextBox textBoxStrictness;
        private TextBox textBoxContacts;
        private TextBox textBoxRadius;
        private Label label_stats;
        private Label label_healthy;
        private Label label_patients;
        private Label label10;
        private Label label_recovered;
        private Label label_recoveredCount;
        private Label label_patientsCount;
        private Label label_healthyCount;
    }
}