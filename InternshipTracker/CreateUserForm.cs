using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class CreateUserForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
       

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblRole = new Label();
            this.cmbRole = new ComboBox();
            this.lblFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.btnCreate = new Button();
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
            this.lblTitle.Size = new Size(250, 30);
            this.lblTitle.Text = "Create User Account";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = TextColor;
            this.lblUsername.Location = new Point(30, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(75, 19);
            this.lblUsername.Text = "Username:";

            // txtUsername
            this.txtUsername.BackColor = Color.FromArgb(40, 40, 40);
            this.txtUsername.ForeColor = TextColor;
            this.txtUsername.Font = new Font("Segoe UI", 10F);
            this.txtUsername.Location = new Point(150, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(250, 25);
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = TextColor;
            this.lblPassword.Location = new Point(30, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(73, 19);
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.BackColor = Color.FromArgb(40, 40, 40);
            this.txtPassword.ForeColor = TextColor;
            this.txtPassword.Font = new Font("Segoe UI", 10F);
            this.txtPassword.Location = new Point(150, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(250, 25);
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new Font("Segoe UI", 10F);
            this.lblRole.ForeColor = TextColor;
            this.lblRole.Location = new Point(30, 150);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new Size(40, 19);
            this.lblRole.Text = "Role:";

            // cmbRole
            this.cmbRole.BackColor = Color.FromArgb(40, 40, 40);
            this.cmbRole.ForeColor = TextColor;
            this.cmbRole.Font = new Font("Segoe UI", 10F);
            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRole.FlatStyle = FlatStyle.Flat;
            this.cmbRole.Location = new Point(150, 147);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new Size(250, 25);
            this.cmbRole.Items.AddRange(new object[] { "Student", "CompanyHR", "Supervisor", "Admin" });

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new Font("Segoe UI", 10F);
            this.lblFirstName.ForeColor = TextColor;
            this.lblFirstName.Location = new Point(30, 190);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new Size(80, 19);
            this.lblFirstName.Text = "First Name:";

            // txtFirstName
            this.txtFirstName.BackColor = Color.FromArgb(40, 40, 40);
            this.txtFirstName.ForeColor = TextColor;
            this.txtFirstName.Font = new Font("Segoe UI", 10F);
            this.txtFirstName.Location = new Point(150, 187);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new Size(250, 25);
            this.txtFirstName.BorderStyle = BorderStyle.FixedSingle;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new Font("Segoe UI", 10F);
            this.lblLastName.ForeColor = TextColor;
            this.lblLastName.Location = new Point(30, 230);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new Size(79, 19);
            this.lblLastName.Text = "Last Name:";

            // txtLastName
            this.txtLastName.BackColor = Color.FromArgb(40, 40, 40);
            this.txtLastName.ForeColor = TextColor;
            this.txtLastName.Font = new Font("Segoe UI", 10F);
            this.txtLastName.Location = new Point(150, 227);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(250, 25);
            this.txtLastName.BorderStyle = BorderStyle.FixedSingle;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = TextColor;
            this.lblEmail.Location = new Point(30, 270);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(47, 19);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.BackColor = Color.FromArgb(40, 40, 40);
            this.txtEmail.ForeColor = TextColor;
            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.Location = new Point(150, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(250, 25);
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;

            // btnCreate
            this.btnCreate.BackColor = AccentColor;
            this.btnCreate.FlatStyle = FlatStyle.Flat;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCreate.ForeColor = TextColor;
            this.btnCreate.Location = new Point(180, 320);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new Size(100, 35);
            this.btnCreate.Text = "Create";
            this.btnCreate.Cursor = Cursors.Hand;
            this.btnCreate.Click += new EventHandler(this.btnCreate_Click);

            // btnCancel
            this.btnCancel.BackColor = AccentColor;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.ForeColor = TextColor;
            this.btnCancel.Location = new Point(300, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // CreateUserForm
            this.ClientSize = new Size(450, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateUserForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Create User Account";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnCreate;
        private Button btnCancel;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    // Insert user
                    string userQuery = "INSERT INTO users (username, password, role) OUTPUT INSERTED.id VALUES (@username, @password, @role)";
                    int userId;

                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                        userId = (int)cmd.ExecuteScalar();
                    }

                    // Insert role-specific data
                    string roleQuery = "";
                    switch (cmbRole.SelectedItem.ToString())
                    {
                        case "Student":
                            roleQuery = "INSERT INTO students (userID, firstName, lastName, email, phoneNumber, birthdate, major, gpa) VALUES (@userID, @firstName, @lastName, @email, '', '2000-01-01', 'Undeclared', 0.0)";
                            break;
                        case "CompanyHR":
                            roleQuery = "INSERT INTO companyHR (userID, companyID, firstName, lastName, email) VALUES (@userID, 1, @firstName, @lastName, @email)";
                            break;
                        case "Supervisor":
                            roleQuery = "INSERT INTO supervisors (userID, firstName, lastName, email, department) VALUES (@userID, @firstName, @lastName, @email, 'General')";
                            break;
                        case "Admin":
                            roleQuery = "INSERT INTO admin (userID, firstName, lastName, email, department) VALUES (@userID, @firstName, @lastName, @email, 'Career Services')";
                            break;
                    }

                    using (SqlCommand cmd = new SqlCommand(roleQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", userId);
                        cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter a last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
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