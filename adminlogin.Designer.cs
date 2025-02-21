namespace Veterinary_Management_System
{
    partial class adminlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminlogin));
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            loginbutton = new Button();
            label7 = new Label();
            passwordtextbox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            usernametextbox = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(456, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 621);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(537, 0);
            button1.Name = "button1";
            button1.Size = new Size(56, 43);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 89);
            label4.Name = "label4";
            label4.Size = new Size(390, 20);
            label4.TabIndex = 6;
            label4.Text = "To keep you connected with us, please login here.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(67, 37);
            label3.Name = "label3";
            label3.Size = new Size(494, 42);
            label3.TabIndex = 5;
            label3.Text = "WELCOME TO ASSUMPTA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(loginbutton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(passwordtextbox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(usernametextbox);
            panel2.Location = new Point(145, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 451);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(86, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.SeaGreen;
            loginbutton.Cursor = Cursors.Hand;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Location = new Point(74, 343);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(172, 32);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "LOG IN";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(111, 293);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 4;
            label7.Text = "Password";
            // 
            // passwordtextbox
            // 
            passwordtextbox.Cursor = Cursors.IBeam;
            passwordtextbox.Location = new Point(28, 263);
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.PasswordChar = '●';
            passwordtextbox.Size = new Size(246, 27);
            passwordtextbox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 227);
            label6.Name = "label6";
            label6.Size = new Size(88, 22);
            label6.TabIndex = 2;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 136);
            label5.Name = "label5";
            label5.Size = new Size(232, 34);
            label5.TabIndex = 1;
            label5.Text = "ADMIN LOGIN";
            // 
            // usernametextbox
            // 
            usernametextbox.Location = new Point(28, 197);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.Size = new Size(246, 27);
            usernametextbox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(97, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 219);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(34, 178);
            label1.Name = "label1";
            label1.Size = new Size(393, 25);
            label1.TabIndex = 2;
            label1.Text = "ASSUMPTA DOG AND CAT CLINIC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(143, 468);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 3;
            label2.Text = "ANTIPOLO";
            // 
            // adminlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 620);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminlogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button loginbutton;
        private Label label7;
        private TextBox passwordtextbox;
        private Label label6;
        private Label label5;
        private TextBox usernametextbox;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}