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
            lblTitle = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblBirthdate = new Label();
            dtpBirthdate = new DateTimePicker();
            lblMajor = new Label();
            txtMajor = new TextBox();
            lblGpa = new Label();
            txtGpa = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Profile";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.Location = new Point(30, 80);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(40, 40, 40);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(150, 77);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 30);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.Location = new Point(30, 120);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(40, 40, 40);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(150, 117);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 30);
            txtLastName.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(30, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(40, 40, 40);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(150, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 30);
            txtEmail.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(30, 200);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(63, 23);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(40, 40, 40);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(150, 197);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 30);
            txtPhone.TabIndex = 8;
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Font = new Font("Segoe UI", 10F);
            lblBirthdate.Location = new Point(30, 240);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(84, 23);
            lblBirthdate.TabIndex = 9;
            lblBirthdate.Text = "Birthdate:";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            dtpBirthdate.Font = new Font("Segoe UI", 10F);
            dtpBirthdate.Location = new Point(150, 237);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(250, 30);
            dtpBirthdate.TabIndex = 10;
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Font = new Font("Segoe UI", 10F);
            lblMajor.Location = new Point(30, 280);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(58, 23);
            lblMajor.TabIndex = 11;
            lblMajor.Text = "Major:";
            // 
            // txtMajor
            // 
            txtMajor.BackColor = Color.FromArgb(40, 40, 40);
            txtMajor.BorderStyle = BorderStyle.FixedSingle;
            txtMajor.Font = new Font("Segoe UI", 10F);
            txtMajor.Location = new Point(150, 277);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(250, 30);
            txtMajor.TabIndex = 12;
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Font = new Font("Segoe UI", 10F);
            lblGpa.Location = new Point(30, 320);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(46, 23);
            lblGpa.TabIndex = 13;
            lblGpa.Text = "GPA:";
            // 
            // txtGpa
            // 
            txtGpa.BackColor = Color.FromArgb(40, 40, 40);
            txtGpa.BorderStyle = BorderStyle.FixedSingle;
            txtGpa.Font = new Font("Segoe UI", 10F);
            txtGpa.Location = new Point(150, 317);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(100, 30);
            txtGpa.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(200, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(310, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // StudentProfileForm
            // 
            ClientSize = new Size(450, 440);
            Controls.Add(lblTitle);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblBirthdate);
            Controls.Add(dtpBirthdate);
            Controls.Add(lblMajor);
            Controls.Add(txtMajor);
            Controls.Add(lblGpa);
            Controls.Add(txtGpa);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentProfileForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Profile";
            ResumeLayout(false);
            PerformLayout();
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
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
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
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
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