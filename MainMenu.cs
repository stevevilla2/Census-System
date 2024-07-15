using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Census_System
{
    public partial class MainMenu : Form
    {
        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        private SQLiteDataReader dr;
        private string _loggedInUsername;


        public MainMenu()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=database.db;Version=3");
            this.Load += MainMenu_Load; // Ensure LoadRecord is called on initialization
        }

        // Constructor that accepts a username
        public MainMenu(string username)
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=database.db;Version=3");
            _loggedInUsername = username;
            UpdateGreetingLabel();
            timer1.Start();
            this.Load += MainMenu_Load; // Ensure LoadRecord is called on initialization
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void UpdateGreetingLabel()
        {
            if (!string.IsNullOrEmpty(_loggedInUsername))
            {
                Hello.Text = $"Hello! {_loggedInUsername}";
            }
            else
            {
                Hello.Text = "!";
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
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
                this.Dispose();
            }
        }

        private void label_familycount_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                    if (colName == "btn_edit")
                    {
                        AddNew f = new AddNew(this);
                        this.Hide();
                        f.btnSave.Enabled = false;
                        f._ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        f.txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        f.dtBirthDate.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        f.txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        f.cboGender.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        f.cboMaritalStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                        f.txtCitizenship.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                        f.txtReligion.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                        f.txtIndigenousGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                        f.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                        f.txtMobileNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                        f.txtEmailAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                        f.cboRel.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                        f.txtHouseholdSize.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                        f.cboEducationalAttainment.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                        f.txtSchoolAttended.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                        f.cboEnrollmentStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                        f.cboEmploymentStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                        f.txtHealthInsurance.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                        f.cboVoterStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
                        f.txtDisability.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
                        f.ShowDialog();
                    }
                    else if (colName == "btn_delete")
                    {
                        if (MessageBox.Show("Do you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            conn.Open();
                            cmd = new SQLiteCommand("DELETE FROM personal_information WHERE id = @id", conn);
                            cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Record has been successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadRecord();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Index is out of bounds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            new AddNew().Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRecord();
                UpdateFamilyCountLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        private void UpdateFamilyCountLabel()
        {
            label_familycount.Text = $"{dataGridView1.Rows.Count}";
        }
        public void LoadRecord()
        {
            try
            {
                dataGridView1.Rows.Clear();
                conn.Open();
                cmd = new SQLiteCommand("SELECT * FROM personal_information", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int v = dataGridView1.Rows.Add(
                            dr["id"].ToString(),
                            dr["fullname"].ToString(),
                            DateTime.Parse(dr["date_of_birth"].ToString()).ToShortDateString(),
                            dr["age"].ToString(),
                            dr["gender"].ToString(),
                            dr["marital_status"].ToString(),
                            dr["citizenship"].ToString(),
                            dr["religion"].ToString(),
                            dr["indigenous_group"].ToString(),
                            dr["address"].ToString(),
                            dr["mobile_number"].ToString(),
                            dr["email_address"].ToString(),
                            dr["relationship_to_household_head"].ToString(),
                            dr["household_size"].ToString(),
                            dr["educational_attainment"].ToString(),
                            dr["school_attended"].ToString(),
                            dr["current_enrollment_status"].ToString(),
                            dr["employment_status"].ToString(),
                            dr["health_insurance_coverage"].ToString(),
                            dr["voter_status"].ToString(),
                            dr["disability"].ToString()
                    ) ;
                }

                dr.Close();
                conn.Close();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Hello_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            FilterRecords(searchBox.Text);
        }
        private void FilterRecords(string searchTerm)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isVisible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm.ToLower()))
                    {
                        isVisible = true;
                        break;
                    }
                }
                row.Visible = isVisible;
            }
            UpdateFamilyCountLabel();
        }
    }
}
