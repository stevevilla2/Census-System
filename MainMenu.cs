using System;
using System.Data.SQLite;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

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
            this.Dispose();
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
                f.txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells["full_name"].Value.ToString();
                f.dtBirthDate.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["birth_date"].Value.ToString());
                f.txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells["age"].Value.ToString();
                f.cboGender.Text = dataGridView1.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                f.cboMaritalStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["marital_status"].Value.ToString();
                f.txtCitizenship.Text = dataGridView1.Rows[e.RowIndex].Cells["citizenship"].Value.ToString();
                f.txtReligion.Text = dataGridView1.Rows[e.RowIndex].Cells["religion"].Value.ToString();
                f.txtIndigenousGroup.Text = dataGridView1.Rows[e.RowIndex].Cells["indigenous_group"].Value.ToString();
                f.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
                f.txtMobileNumber.Text = dataGridView1.Rows[e.RowIndex].Cells["mobile_number"].Value.ToString();
                f.txtEmailAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["email_address"].Value.ToString();
                f.cboRel.Text = dataGridView1.Rows[e.RowIndex].Cells["relationship"].Value.ToString();
                f.txtHouseholdSize.Text = dataGridView1.Rows[e.RowIndex].Cells["household_size"].Value.ToString();
                f.cboEducationalAttainment.Text = dataGridView1.Rows[e.RowIndex].Cells["educational_attainment"].Value.ToString();
                f.txtSchoolAttended.Text = dataGridView1.Rows[e.RowIndex].Cells["school_attended"].Value.ToString();
                f.cboEnrollmentStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["current_enrollment_status"].Value.ToString();
                f.cboEmploymentStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["employment_status"].Value.ToString();
                f.txtHealthInsurance.Text = dataGridView1.Rows[e.RowIndex].Cells["health_insurance"].Value.ToString();
                f.cboVoterStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["voter_status"].Value.ToString();
                f.txtDisability.Text = dataGridView1.Rows[e.RowIndex].Cells["disability"].Value.ToString();
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
                    );
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Personal Information");

                    // Add headers, excluding the first column and the last two columns
                    for (int i = 1; i < dataGridView1.Columns.Count - 2; i++)
                    {
                        worksheet.Cell(1, i).Value = dataGridView1.Columns[i].HeaderText;
                    }

                    // Add data rows, excluding the first column and the last two columns
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridView1.Columns.Count - 2; j++)
                        {
                            worksheet.Cell(i + 2, j).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Format headers and cells
                    worksheet.Range("1:1").Style.Font.Bold = true;
                    worksheet.Columns().AdjustToContents();

                    // Save the Excel file
                    var saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.FileName = "PersonalInformation.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Export successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
