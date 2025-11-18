using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class StudentDashboard : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
        

        public StudentDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new Label();
            this.dgvInternships = new DataGridView();
            this.dgvMyApplications = new DataGridView();
            this.btnApply = new Button();
            this.btnViewProfile = new Button();
            this.btnLogout = new Button();
            this.lblAvailableInternships = new Label();
            this.lblMyApplications = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInternships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyApplications)).BeginInit();
            this.SuspendLayout();

            // Form
            this.BackColor = BackgroundColor;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblWelcome.ForeColor = AccentColor;
            this.lblWelcome.Location = new Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(300, 30);
            this.lblWelcome.Text = "Student Dashboard";

            // lblAvailableInternships
            this.lblAvailableInternships.AutoSize = true;
            this.lblAvailableInternships.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblAvailableInternships.ForeColor = TextColor;
            this.lblAvailableInternships.Location = new Point(20, 70);
            this.lblAvailableInternships.Name = "lblAvailableInternships";
            this.lblAvailableInternships.Size = new Size(175, 20);
            this.lblAvailableInternships.Text = "Available Internships";

            // dgvInternships
            this.dgvInternships.AllowUserToAddRows = false;
            this.dgvInternships.AllowUserToDeleteRows = false;
            this.dgvInternships.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvInternships.BorderStyle = BorderStyle.None;
            this.dgvInternships.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
            this.dgvInternships.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            this.dgvInternships.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvInternships.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            this.dgvInternships.DefaultCellStyle.ForeColor = TextColor;
            this.dgvInternships.DefaultCellStyle.SelectionBackColor = AccentColor;
            this.dgvInternships.DefaultCellStyle.SelectionForeColor = TextColor;
            this.dgvInternships.EnableHeadersVisualStyles = false;
            this.dgvInternships.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvInternships.Location = new Point(20, 100);
            this.dgvInternships.Name = "dgvInternships";
            this.dgvInternships.ReadOnly = true;
            this.dgvInternships.RowHeadersVisible = false;
            this.dgvInternships.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternships.Size = new Size(960, 220);

            // btnApply
            this.btnApply.BackColor = AccentColor;
            this.btnApply.FlatStyle = FlatStyle.Flat;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnApply.ForeColor = TextColor;
            this.btnApply.Location = new Point(880, 330);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new Size(100, 35);
            this.btnApply.Text = "Apply";
            this.btnApply.Cursor = Cursors.Hand;
            this.btnApply.Click += new EventHandler(this.btnApply_Click);

            // lblMyApplications
            this.lblMyApplications.AutoSize = true;
            this.lblMyApplications.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblMyApplications.ForeColor = TextColor;
            this.lblMyApplications.Location = new Point(20, 380);
            this.lblMyApplications.Name = "lblMyApplications";
            this.lblMyApplications.Size = new Size(130, 20);
            this.lblMyApplications.Text = "My Applications";

            // dgvMyApplications
            this.dgvMyApplications.AllowUserToAddRows = false;
            this.dgvMyApplications.AllowUserToDeleteRows = false;
            this.dgvMyApplications.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvMyApplications.BorderStyle = BorderStyle.None;
            this.dgvMyApplications.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
            this.dgvMyApplications.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            this.dgvMyApplications.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvMyApplications.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            this.dgvMyApplications.DefaultCellStyle.ForeColor = TextColor;
            this.dgvMyApplications.DefaultCellStyle.SelectionBackColor = AccentColor;
            this.dgvMyApplications.DefaultCellStyle.SelectionForeColor = TextColor;
            this.dgvMyApplications.EnableHeadersVisualStyles = false;
            this.dgvMyApplications.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvMyApplications.Location = new Point(20, 410);
            this.dgvMyApplications.Name = "dgvMyApplications";
            this.dgvMyApplications.ReadOnly = true;
            this.dgvMyApplications.RowHeadersVisible = false;
            this.dgvMyApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyApplications.Size = new Size(960, 150);

            // btnViewProfile
            this.btnViewProfile.BackColor = AccentColor;
            this.btnViewProfile.FlatStyle = FlatStyle.Flat;
            this.btnViewProfile.FlatAppearance.BorderSize = 0;
            this.btnViewProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnViewProfile.ForeColor = TextColor;
            this.btnViewProfile.Location = new Point(660, 575);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new Size(200, 35);
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.Cursor = Cursors.Hand;
            this.btnViewProfile.Click += new EventHandler(this.btnViewProfile_Click);

            // btnLogout
            this.btnLogout.BackColor = AccentColor;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = TextColor;
            this.btnLogout.Location = new Point(880, 575);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(100, 35);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // StudentDashboard
            this.ClientSize = new Size(1000, 630);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblAvailableInternships);
            this.Controls.Add(this.dgvInternships);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblMyApplications);
            this.Controls.Add(this.dgvMyApplications);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnLogout);
            this.Name = "StudentDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard - Internship Tracker";
            this.FormClosed += new FormClosedEventHandler(this.StudentDashboard_FormClosed);

            ((System.ComponentModel.ISupportInitialize)(this.dgvInternships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblWelcome;
        private Label lblAvailableInternships;
        private Label lblMyApplications;
        private DataGridView dgvInternships;
        private DataGridView dgvMyApplications;
        private Button btnApply;
        private Button btnViewProfile;
        private Button btnLogout;

        private void LoadData()
        {
            LoadAvailableInternships();
            LoadMyApplications();
        }

        private void LoadAvailableInternships()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT i.id, c.companyName, i.title, i.deadline, i.requirements 
                                   FROM internships i 
                                   INNER JOIN companies c ON i.companyID = c.id 
                                   WHERE i.isActive = 1 AND i.deadline >= GETDATE()
                                   ORDER BY i.deadline";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvInternships.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading internships: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMyApplications()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT a.id, c.companyName, i.title, a.status, a.submissionDate 
                                   FROM applications a 
                                   INNER JOIN internships i ON a.internshipID = i.id 
                                   INNER JOIN companies c ON i.companyID = c.id 
                                   WHERE a.studentID = @studentID
                                   ORDER BY a.submissionDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", UserSession.ProfileId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvMyApplications.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvInternships.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an internship to apply for.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int internshipId = Convert.ToInt32(dgvInternships.SelectedRows[0].Cells["id"].Value);
            ApplicationForm appForm = new ApplicationForm(internshipId, UserSession.ProfileId);
            appForm.ShowDialog();
            LoadMyApplications();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            StudentProfileForm profileForm = new StudentProfileForm(UserSession.ProfileId);
            profileForm.ShowDialog();
            LoadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!UserSession.IsLoggedIn())
            {
                Application.Exit();
            }
        }
    }
}