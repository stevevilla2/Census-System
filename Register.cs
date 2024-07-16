using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Census_System
{
    public partial class Register : Form
    {
        private SQLiteConnection conn;
        public Register()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=database.db;Version=3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtComPassword.Text))
            {
                MessageBox.Show("All fields are required.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtComPassword.Clear();
                txtPassword.Focus();
                return;
            }

            if (!IsPasswordStrong(txtPassword.Text))
            {
                MessageBox.Show("Password is not strong enough. It should be at least 8 characters long and contain a mix of uppercase, lowercase, numbers, and symbols.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();

                // Check if username already exists
                if (UsernameExists(txtUsername.Text))
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hash the password before storing it
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

                // Parameterized query for registration
                string registerQuery = "INSERT INTO login (username, password) VALUES (@username, @hashedPassword)";
                using (SQLiteCommand cmd = new SQLiteCommand(registerQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Your Account has been successfully created.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open login form
                LogIn loginForm = new LogIn();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception (optional, for debugging)
                // ... (add logging code here)
            }
            finally
            {
                conn.Close();
            }
        }
        private bool IsPasswordStrong(string password)
        {
            // Implement your password strength rules here
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        // Helper function to check if username exists
        private bool UsernameExists(string username)
        {
            string checkQuery = "SELECT COUNT(*) FROM login WHERE username = @username";
            using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@username", username);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
