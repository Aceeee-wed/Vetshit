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
    public partial class SupAdDoctor : Form
    {
        public SupAdDoctor()
        {
            InitializeComponent();
        }

        private void SupAdDoctor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupAdCreate supAdCreate = new SupAdCreate();
            supAdCreate.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SupAdHistory supAdHistory = new SupAdHistory();
            supAdHistory.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SupAdServices supAdServices = new SupAdServices();
            supAdServices.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            SupAdEmployee supAdEmployee = new SupAdEmployee();
            supAdEmployee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupAdLogin supAdLogin = new SupAdLogin();
            supAdLogin.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
