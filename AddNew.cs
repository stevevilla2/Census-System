using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Census_System
{
    public partial class AddNew : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        MainMenu f;
        public string _ID;
        public AddNew()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=database.db;Version=3");
            cmd = new SQLiteCommand();
        }

        public AddNew(MainMenu f) : this()  // Ensure the base constructor is called
        {
            this.f = f;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
            this.Hide();
            this.Dispose();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save this record?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "INSERT INTO personal_information (fullname, date_of_birth, age, gender, marital_status, citizenship, religion, indigenous_group, address, mobile_number, email_address, relationship_to_household_head, household_size, educational_attainment, school_attended, current_enrollment_status, employment_status, health_insurance_coverage, voter_status, disability) " +
                                "VALUES (@fullname, @date_of_birth, @age, @gender, @marital_status, @citizenship, @religion, @indigenous_group, @address, @mobile_number, @email_address, @relationship_to_household_head, @household_size, @educational_attainment, @school_attended, @current_enrollment_status, @employment_status, @health_insurance_coverage, @voter_status, @disability)";
                    cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _ID);
                    cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", dtBirthDate.Value);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);  // Ensure txtAge.Text is used, not txtAge
                    cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                    cmd.Parameters.AddWithValue("@marital_status", cboMaritalStatus.Text);
                    cmd.Parameters.AddWithValue("@citizenship", txtCitizenship.Text);
                    cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
                    cmd.Parameters.AddWithValue("@indigenous_group", txtIndigenousGroup.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@mobile_number", txtMobileNumber.Text);
                    cmd.Parameters.AddWithValue("@email_address", txtEmailAddress.Text);
                    cmd.Parameters.AddWithValue("@relationship_to_household_head", cboRel.Text);
                    cmd.Parameters.AddWithValue("@household_size", txtHouseholdSize.Text);
                    cmd.Parameters.AddWithValue("@educational_attainment", cboEducationalAttainment.Text);
                    cmd.Parameters.AddWithValue("@school_attended", txtSchoolAttended.Text);
                    cmd.Parameters.AddWithValue("@current_enrollment_status", cboEnrollmentStatus.Text);  // Correct control used
                    cmd.Parameters.AddWithValue("@employment_status", cboEmploymentStatus.Text);
                    cmd.Parameters.AddWithValue("@health_insurance_coverage", txtHealthInsurance.Text);
                    cmd.Parameters.AddWithValue("@voter_status", cboVoterStatus.Text);
                    cmd.Parameters.AddWithValue("@disability", txtDisability.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    if (f != null)
                    {
                        f.LoadRecord();
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "UPDATE personal_information SET fullname = @fullname, date_of_birth = @date_of_birth, age = @age, gender = @gender, marital_status = @marital_status," +
                        " citizenship = @citizenship, religion = @religion, indigenous_group = @indigenous_group, address = @address, mobile_number = @mobile_number, email_address = @email_address," +
                        " relationship_to_household_head = @relationship_to_household_head, household_size = @household_size, educational_attainment = @educational_attainment, school_attended = @school_attended," +
                        " current_enrollment_status = @current_enrollment_status, employment_status = @employment_status, health_insurance_coverage = @health_insurance_coverage, voter_status = @voter_status, disability = @disability WHERE id = @id";  // Add WHERE clause with id
                    cmd = new SQLiteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", dtBirthDate.Value);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);  // Ensure txtAge.Text is used, not txtAge
                    cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                    cmd.Parameters.AddWithValue("@marital_status", cboMaritalStatus.Text);
                    cmd.Parameters.AddWithValue("@citizenship", txtCitizenship.Text);
                    cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
                    cmd.Parameters.AddWithValue("@indigenous_group", txtIndigenousGroup.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@mobile_number", txtMobileNumber.Text);
                    cmd.Parameters.AddWithValue("@email_address", txtEmailAddress.Text);
                    cmd.Parameters.AddWithValue("@relationship_to_household_head", cboRel.Text);
                    cmd.Parameters.AddWithValue("@household_size", txtHouseholdSize.Text);
                    cmd.Parameters.AddWithValue("@educational_attainment", cboEducationalAttainment.Text);
                    cmd.Parameters.AddWithValue("@school_attended", txtSchoolAttended.Text);
                    cmd.Parameters.AddWithValue("@current_enrollment_status", cboEnrollmentStatus.Text);  // Correct control used
                    cmd.Parameters.AddWithValue("@employment_status", cboEmploymentStatus.Text);
                    cmd.Parameters.AddWithValue("@health_insurance_coverage", txtHealthInsurance.Text);
                    cmd.Parameters.AddWithValue("@voter_status", cboVoterStatus.Text);
                    cmd.Parameters.AddWithValue("@disability", txtDisability.Text);
                    cmd.Parameters.AddWithValue("@id", _ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully updated!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();    // Reset form fields
                    f.LoadRecord(); // Refresh parent form or data grid
                    this.Dispose(); // Dispose the current form if needed
                    new MainMenu().Show();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clear()
        {
            txtEmailAddress.Clear();
            txtAddress.Clear();
            txtMobileNumber.Clear();
            cboRel.SelectedIndex = -1;
            txtHouseholdSize.Clear();
            cboEducationalAttainment.SelectedIndex = -1;
            txtSchoolAttended.Clear();
            cboEnrollmentStatus.SelectedIndex = -1;
            cboEmploymentStatus.SelectedIndex = -1;
            txtHealthInsurance.Clear();
            txtDisability.Clear();
            cboVoterStatus.SelectedIndex = -1;
            txtFullName.Clear();
            dtBirthDate.Value = DateTime.Now;
            txtAge.Clear();
            cboGender.SelectedIndex = -1;
            cboMaritalStatus.SelectedIndex = -1;
            txtCitizenship.Clear();
            txtReligion.Clear();
            txtIndigenousGroup.Clear();
            txtFullName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            new MainMenu().Show();
            this.Hide();
        }
    }
}

