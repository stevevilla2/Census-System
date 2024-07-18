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
            // Start the timer when the form initializes
            timer1.Start();
            UpdateFamilyCountLabel();
            UpdateGreetingLabel();
            Load += MainMenu_Load; // Hook into the Load event
            dataGridView1.CellContentClick += dataGridView1_CellContentClick; // Add this line
        }

        // Constructor that accepts a username
public MainMenu(string username = null) // Allow null for default parameter
{
    InitializeComponent();
    conn = new SQLiteConnection("Data Source=database.db;Version=3");
    timer1.Start();
    _loggedInUsername = username;
    UpdateGreetingLabel();
    Load += MainMenu_Load; 
    dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
                Hello.Text = "";
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update labels with current date, time, and any other dynamic data
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            UpdateGreetingLabel(); // Update greeting label continuously
            UpdateFamilyCountLabel(); // Update family count label continuously
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
                else
                {
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
                AddButtonColumns(); // Add button columns
                LoadRecord(); // Load records initially
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void AddButtonColumns()
        {
            if (!dataGridView1.Columns.Contains("btn_edit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "btn_edit";
                btnEdit.HeaderText = "";
                btnEdit.Text = "Edit";
                btnEdit.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnEdit);
            }

            if (!dataGridView1.Columns.Contains("btn_delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btn_delete";
                btnDelete.HeaderText = "";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnDelete);
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
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        isVisible = true;
                        break;
                    }
                }
                row.Visible = isVisible;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportDataToExcel();
        }

        private void ExportDataToExcel()
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Personal Information");

                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Data has been successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
