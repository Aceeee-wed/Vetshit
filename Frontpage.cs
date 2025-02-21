using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 LogInform = new Form2(); // Replace Form1 with your main application form
            LogInform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Services services = new Services(); // Replace Form1 with your main application form
            services.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About_us about = new About_us(); // Replace Form1 with your main application form
            about.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //Close the Application
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
