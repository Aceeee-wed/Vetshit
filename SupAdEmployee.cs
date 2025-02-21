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
    public partial class SupAdEmployee : Form
    {
        public SupAdEmployee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void SupAdEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SupAdDoctor supAdDoctor = new SupAdDoctor();
            supAdDoctor.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SupAdServices supAdServices = new SupAdServices();
            supAdServices.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupAdCreate supAdCreate = new SupAdCreate();
            supAdCreate.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SupAdHistory supAdHistory = new SupAdHistory();
            supAdHistory.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupAdLogin supAdLogin = new SupAdLogin();
            supAdLogin.Show();
            this.Hide();
        }
    }
}
