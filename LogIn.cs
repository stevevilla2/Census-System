using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace Census_System
{
    public partial class LogIn : Form
    {
        private SQLiteConnection conn;
        public LogIn()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=database.db;Version=3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Secure parameterized query with password hashing
                string loginQuery = "SELECT username, password FROM login WHERE username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(loginQuery, conn))
                {
                    // Input validation (also trim whitespace)
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter both username and password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@username", username);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Hash verification
                            string hashedPasswordFromDb = dr["password"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDb))
                            {
                                // Successful login (open MainMenu on the UI thread)
                                string retrievedUsername = dr["username"].ToString();
                                this.BeginInvoke(new Action(() =>
                                {
                                    MainMenu mainMenuForm = new MainMenu(retrievedUsername);
                                    mainMenuForm.Show();
                                    this.Hide();
                                }));
                            }
                            else
                            {
                                // Incorrect password
                                MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Text = ""; // Clear the password field
                                txtPassword.Focus();   // Set focus back to the password field
                            }
                        }
                        else
                        {
                            // Username not found
                            MessageBox.Show("Invalid username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Text = "";
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
