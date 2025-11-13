using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class StudentProfileForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madiou\source\repos\InternshipTracker\InternshipTracker\db.mdf;Integrated Security=True";

        private int studentId;
        private Student currentStudent;

        public StudentProfileForm(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            LoadStudentData();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblBirthdate = new Label();
            this.dtpBirthdate = new DateTimePicker();
            this.lblMajor = new Label();
            this.txtMajor = new TextBox();
            this.lblGpa = new Label();
            this.txtGpa = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // Form
            this.BackColor = BackgroundColor;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = AccentColor;
            this.lblTitle.Location = new Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(200, 30);
            this.lblTitle.Text = "Student Profile";

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new Font("Segoe UI", 10F);
            this.lblFirstName.ForeColor = TextColor;
            this.lblFirstName.Location = new Point(30, 80);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new Size(80, 19);
            this.lblFirstName.Text = "First Name:";

            // txtFirstName
            this.txtFirstName.BackColor = Color.FromArgb(40, 40, 40);
            this.txtFirstName.ForeColor = TextColor;
            this.txtFirstName.Font = new Font("Segoe UI", 10F);
            this.txtFirstName.Location = new Point(150, 77);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new Size(250, 25);
            this.txtFirstName.BorderStyle = BorderStyle.FixedSingle;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new Font("Segoe UI", 10F);
            this.lblLastName.ForeColor = TextColor;
            this.lblLastName.Location = new Point(30, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new Size(79, 19);
            this.lblLastName.Text = "Last Name:";

            // txtLastName
            this.txtLastName.BackColor = Color.FromArgb(40, 40, 40);
            this.txtLastName.ForeColor = TextColor;
            this.txtLastName.Font = new Font("Segoe UI", 10F);
            this.txtLastName.Location = new Point(150, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(250, 25);
            this.txtLastName.BorderStyle = BorderStyle.FixedSingle;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = TextColor;
            this.lblEmail.Location = new Point(30, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(47, 19);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.BackColor = Color.FromArgb(40, 40, 40);
            this.txtEmail.ForeColor = TextColor;
            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.Location = new Point(150, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(250, 25);
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = TextColor;
            this.lblPhone.Location = new Point(30, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(51, 19);
            this.lblPhone.Text = "Phone:";

            // txtPhone
            this.txtPhone.BackColor = Color.FromArgb(40, 40, 40);
            this.txtPhone.ForeColor = TextColor;
            this.txtPhone.Font = new Font("Segoe UI", 10F);
            this.txtPhone.Location = new Point(150, 197);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(250, 25);
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;

            // lblBirthdate
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new Font("Segoe UI", 10F);
            this.lblBirthdate.ForeColor = TextColor;
            this.lblBirthdate.Location = new Point(30, 240);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new Size(72, 19);
            this.lblBirthdate.Text = "Birthdate:";

            // dtpBirthdate
            this.dtpBirthdate.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            this.dtpBirthdate.CalendarForeColor = TextColor;
            this.dtpBirthdate.Font = new Font("Segoe UI", 10F);
            this.dtpBirthdate.Location = new Point(150, 237);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new Size(250, 25);

            // lblMajor
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new Font("Segoe UI", 10F);
            this.lblMajor.ForeColor = TextColor;
            this.lblMajor.Location = new Point(30, 280);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new Size(50, 19);
            this.lblMajor.Text = "Major:";

            // txtMajor
            this.txtMajor.BackColor = Color.FromArgb(40, 40, 40);
            this.txtMajor.ForeColor = TextColor;
            this.txtMajor.Font = new Font("Segoe UI", 10F);
            this.txtMajor.Location = new Point(150, 277);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new Size(250, 25);
            this.txtMajor.BorderStyle = BorderStyle.FixedSingle;

            // lblGpa
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new Font("Segoe UI", 10F);
            this.lblGpa.ForeColor = TextColor;
            this.lblGpa.Location = new Point(30, 320);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new Size(39, 19);
            this.lblGpa.Text = "GPA:";

            // txtGpa
            this.txtGpa.BackColor = Color.FromArgb(40, 40, 40);
            this.txtGpa.ForeColor = TextColor;
            this.txtGpa.Font = new Font("Segoe UI", 10F);
            this.txtGpa.Location = new Point(150, 317);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new Size(100, 25);
            this.txtGpa.BorderStyle = BorderStyle.FixedSingle;

            // btnSave
            this.btnSave.BackColor = AccentColor;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.ForeColor = TextColor;
            this.btnSave.Location = new Point(200, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 35);
            this.btnSave.Text = "Save";
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = AccentColor;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.ForeColor = TextColor;
            this.btnCancel.Location = new Point(310, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // StudentProfileForm
            this.ClientSize = new Size(450, 440);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "StudentProfileForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Student Profile";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblBirthdate;
        private DateTimePicker dtpBirthdate;
        private Label lblMajor;
        private TextBox txtMajor;
        private Label lblGpa;
        private TextBox txtGpa;
        private Button btnSave;
        private Button btnCancel;

        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM students WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", studentId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentStudent = new Student(
                                    Convert.ToInt32(reader["id"]),
                                    Convert.ToInt32(reader["userID"]),
                                    reader["firstName"].ToString(),
                                    reader["lastName"].ToString(),
                                    reader["email"].ToString(),
                                    reader["phoneNumber"].ToString(),
                                    Convert.ToDateTime(reader["birthdate"]),
                                    reader["major"].ToString(),
                                    Convert.ToDouble(reader["gpa"])
                                );

                                txtFirstName.Text = currentStudent.FirstName;
                                txtLastName.Text = currentStudent.LastName;
                                txtEmail.Text = currentStudent.Email;
                                txtPhone.Text = currentStudent.PhoneNumber;
                                dtpBirthdate.Value = currentStudent.Birthdate;
                                txtMajor.Text = currentStudent.Major;
                                txtGpa.Text = currentStudent.Gpa.ToString("F2");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE students SET 
                                   firstName = @firstName, 
                                   lastName = @lastName, 
                                   email = @email, 
                                   phoneNumber = @phoneNumber, 
                                   birthdate = @birthdate, 
                                   major = @major, 
                                   gpa = @gpa 
                                   WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phoneNumber", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@birthdate", dtpBirthdate.Value);
                        cmd.Parameters.AddWithValue("@major", txtMajor.Text.Trim());
                        cmd.Parameters.AddWithValue("@gpa", Convert.ToDouble(txtGpa.Text.Trim()));
                        cmd.Parameters.AddWithValue("@id", studentId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMajor.Text))
            {
                MessageBox.Show("Please enter major.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMajor.Focus();
                return false;
            }

            double gpa;
            if (!double.TryParse(txtGpa.Text.Trim(), out gpa) || gpa < 0.0 || gpa > 4.0)
            {
                MessageBox.Show("Please enter a valid GPA (0.0 - 4.0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGpa.Focus();
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}