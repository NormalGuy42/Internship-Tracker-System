using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class LoginForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madiou\source\repos\InternshipTracker\InternshipTracker\db.mdf;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.lblTitle = new Label();

            this.SuspendLayout();

            // Form
            this.BackColor = BackgroundColor;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = TextColor;
            this.lblTitle.Location = new Point(70, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(300, 32);
            this.lblTitle.Text = "Internship Tracker Login";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = TextColor;
            this.lblUsername.Location = new Point(50, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(75, 19);
            this.lblUsername.Text = "Username:";

            // txtUsername
            this.txtUsername.BackColor = Color.FromArgb(40, 40, 40);
            this.txtUsername.ForeColor = TextColor;
            this.txtUsername.Font = new Font("Segoe UI", 10F);
            this.txtUsername.Location = new Point(50, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(300, 25);
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = TextColor;
            this.lblPassword.Location = new Point(50, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(73, 19);
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.BackColor = Color.FromArgb(40, 40, 40);
            this.txtPassword.ForeColor = TextColor;
            this.txtPassword.Font = new Font("Segoe UI", 10F);
            this.txtPassword.Location = new Point(50, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new Size(300, 25);
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;

            // btnLogin
            this.btnLogin.BackColor = AccentColor;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnLogin.ForeColor = TextColor;
            this.btnLogin.Location = new Point(125, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(150, 40);
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // LoginForm
            this.ClientSize = new Size(400, 330);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login - Internship Tracker";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblTitle;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, role FROM users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserSession.UserId = Convert.ToInt32(reader["id"]);
                                UserSession.Username = username;
                                UserSession.Role = reader["role"].ToString();
                                reader.Close();

                                GetProfileId(conn);

                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OpenDashboard();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetProfileId(SqlConnection conn)
        {
            string query = "";

            switch (UserSession.Role)
            {
                case "Student":
                    query = "SELECT id FROM students WHERE userID = @userID";
                    break;
                case "CompanyHR":
                    query = "SELECT id FROM companyHR WHERE userID = @userID";
                    break;
                case "Administrator":
                    query = "SELECT id FROM administrators WHERE userID = @userID";
                    break;
                default:
                    return;
            }

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userID", UserSession.UserId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    UserSession.ProfileId = Convert.ToInt32(result);
                }
            }
        }

        private void OpenDashboard()
        {
            switch (UserSession.Role)
            {
                case "Student":
                    new StudentDashboard().Show();
                    break;
                default:
                    MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}