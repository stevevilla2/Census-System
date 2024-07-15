using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Census_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string _loggedInUsername = ""; // To store the username

        // Event handler for the UserLoggedIn event
        public MainMenu(string username)
        {
            InitializeComponent();
            _loggedInUsername = username; // Store the username
            UpdateGreetingLabel(); // Update the greeting label
            timer1.Start(); // Start the timer
        }
        private void UpdateGreetingLabel()
        {
            if (!string.IsNullOrEmpty(_loggedInUsername))
            {
                Hello.Text = $"Hello! {_loggedInUsername}";
            }
            else
            {
                Hello.Text = "!"; // Handle case when username is empty or null
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new LogIn().Show();
                this.Hide();
            }
        }
    }
}
