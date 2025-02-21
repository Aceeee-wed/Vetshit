namespace Veterinary_Management_System
{
    partial class Schedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BackgroundImage = Properties.Resources.bg;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-5, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 651);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.SeaGreen;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.Ivory;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PM", "AM" });
            comboBox1.Location = new Point(41, 505);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "TIME";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGreen;
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(470, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(490, 296);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Ivory;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Consultation", "Vaccination", "Deworming", "X-Ray", "Grooming", "Dental Prophylaxis", "Pharmacy", "Pet Food and Supplies" });
            comboBox2.Location = new Point(183, 226);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(226, 28);
            comboBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 226);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 10;
            label7.Text = "Services:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 170);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 9;
            label6.Text = "Pet's Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 61);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 8;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 115);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Ivory;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(183, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Ivory;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(183, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Ivory;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(183, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.haha;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(41, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 296);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 106);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(914, 3);
            button1.Name = "button1";
            button1.Size = new Size(77, 62);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 36);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 0;
            label1.Text = "SCHEDULE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(16, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 79);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(985, 645);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Schedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox5;
        private Label label7;
        private Label label6;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}