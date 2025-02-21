using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Veterinary_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Define the radius for rounded corners
            int cornerRadius = 20;

            // Get the dimensions of the panel
            int width = panel2.Width;
            int height = panel2.Height;

            // Create a GraphicsPath for rounded corners
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Define the rounded rectangle
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top-left corner
                path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top-right corner
                path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right corner
                path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left corner
                path.CloseAllFigures(); // Close the path to create a rounded rectangle

                // Set the panel region to match the rounded rectangle
                panel2.Region = new Region(path);

                // Optional: Draw the border (customizable)
                using (Pen borderPen = new Pen(Color.Green, 2))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values entered in the username and password textboxes
            string username = usernametextbox.Text.Trim();
            string password = passwordtextbox.Text.Trim();

            // Check if the username or password fields are empty
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the username field is empty
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the password field is empty
            }

            // Simulate user authentication (replace with real authentication logic)
            if (username == "admin" && password == "1234") // Replace with actual user validation
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, proceed to the next form or functionality
                Dashboard dashboard = new Dashboard(); // Replace Form1 with your main application form
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Example: Close the application when the second button is clicked
            Application.Exit();
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Logic for when the username textbox value changes
        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Logic for when the password textbox value changes
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form1 createacc = new Form1(); // Assuming Form2 is another form in your application
            createacc.Show();
            this.Hide();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form3 frontform = new Form3();
            frontform.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
