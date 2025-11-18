using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class AdminDashboard : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;

        public AdminDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblStats = new Label();
            this.lblTotalStudents = new Label();
            this.lblTotalApplications = new Label();
            this.lblPendingApplications = new Label();
            this.lblActiveInternships = new Label();
            this.lblUsers = new Label();
            this.dgvUsers = new DataGridView();
            this.btnCreateUser = new Button();
            this.btnGenerateReport = new Button();
            this.btnLogout = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // Form
            this.BackColor = BackgroundColor;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = AccentColor;
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(280, 30);
            this.lblTitle.Text = "Administrator Dashboard";

            // lblStats
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblStats.ForeColor = TextColor;
            this.lblStats.Location = new Point(20, 70);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new Size(120, 21);
            this.lblStats.Text = "Statistics Overview";

            // lblTotalStudents
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new Font("Segoe UI", 10F);
            this.lblTotalStudents.ForeColor = TextColor;
            this.lblTotalStudents.Location = new Point(40, 110);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new Size(120, 19);
            this.lblTotalStudents.Text = "Total Students: 0";

            // lblTotalApplications
            this.lblTotalApplications.AutoSize = true;
            this.lblTotalApplications.Font = new Font("Segoe UI", 10F);
            this.lblTotalApplications.ForeColor = TextColor;
            this.lblTotalApplications.Location = new Point(40, 140);
            this.lblTotalApplications.Name = "lblTotalApplications";
            this.lblTotalApplications.Size = new Size(150, 19);
            this.lblTotalApplications.Text = "Total Applications: 0";

            // lblPendingApplications
            this.lblPendingApplications.AutoSize = true;
            this.lblPendingApplications.Font = new Font("Segoe UI", 10F);
            this.lblPendingApplications.ForeColor = AccentColor;
            this.lblPendingApplications.Location = new Point(40, 170);
            this.lblPendingApplications.Name = "lblPendingApplications";
            this.lblPendingApplications.Size = new Size(170, 19);
            this.lblPendingApplications.Text = "Pending Applications: 0";

            // lblActiveInternships
            this.lblActiveInternships.AutoSize = true;
            this.lblActiveInternships.Font = new Font("Segoe UI", 10F);
            this.lblActiveInternships.ForeColor = TextColor;
            this.lblActiveInternships.Location = new Point(40, 200);
            this.lblActiveInternships.Name = "lblActiveInternships";
            this.lblActiveInternships.Size = new Size(160, 19);
            this.lblActiveInternships.Text = "Active Internships: 0";

            // lblUsers
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblUsers.ForeColor = TextColor;
            this.lblUsers.Location = new Point(20, 250);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new Size(150, 20);
            this.lblUsers.Text = "User Accounts";

            // dgvUsers
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvUsers.BorderStyle = BorderStyle.None;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvUsers.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            this.dgvUsers.DefaultCellStyle.ForeColor = TextColor;
            this.dgvUsers.DefaultCellStyle.SelectionBackColor = AccentColor;
            this.dgvUsers.DefaultCellStyle.SelectionForeColor = TextColor;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvUsers.Location = new Point(20, 280);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new Size(960, 310);

            // btnCreateUser
            this.btnCreateUser.BackColor = AccentColor;
            this.btnCreateUser.FlatStyle = FlatStyle.Flat;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCreateUser.ForeColor = TextColor;
            this.btnCreateUser.Location = new Point(640, 605);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new Size(150, 35);
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.Cursor = Cursors.Hand;
            this.btnCreateUser.Click += new EventHandler(this.btnCreateUser_Click);

            // btnGenerateReport
            this.btnGenerateReport.BackColor = AccentColor;
            this.btnGenerateReport.FlatStyle = FlatStyle.Flat;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnGenerateReport.ForeColor = TextColor;
            this.btnGenerateReport.Location = new Point(640, 650);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new Size(150, 35);
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Cursor = Cursors.Hand;
            this.btnGenerateReport.Click += new EventHandler(this.btnGenerateReport_Click);

            // btnLogout
            this.btnLogout.BackColor = AccentColor;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = TextColor;
            this.btnLogout.Location = new Point(880, 650);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(100, 35);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // AdminDashboard
            this.ClientSize = new Size(1000, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.lblTotalApplications);
            this.Controls.Add(this.lblPendingApplications);
            this.Controls.Add(this.lblActiveInternships);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Administrator Dashboard - Internship Tracker";
            this.FormClosed += new FormClosedEventHandler(this.AdminDashboard_FormClosed);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblStats;
        private Label lblTotalStudents;
        private Label lblTotalApplications;
        private Label lblPendingApplications;
        private Label lblActiveInternships;
        private Label lblUsers;
        private DataGridView dgvUsers;
        private Button btnCreateUser;
        private Button btnGenerateReport;
        private Button btnLogout;

        private void LoadData()
        {
            LoadStatistics();
            LoadUsers();
        }

        private void LoadStatistics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    // Total Students
                    string query1 = "SELECT COUNT(*) FROM students";
                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalStudents.Text = $"Total Students: {count}";
                    }

                    // Total Applications
                    string query2 = "SELECT COUNT(*) FROM applications";
                    using (SqlCommand cmd = new SqlCommand(query2, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalApplications.Text = $"Total Applications: {count}";
                    }

                    // Pending Applications
                    string query3 = "SELECT COUNT(*) FROM applications WHERE status = 'Pending'";
                    using (SqlCommand cmd = new SqlCommand(query3, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblPendingApplications.Text = $"Pending Applications: {count}";
                    }

                    // Active Internships
                    string query4 = "SELECT COUNT(*) FROM internships WHERE isActive = 1";
                    using (SqlCommand cmd = new SqlCommand(query4, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblActiveInternships.Text = $"Active Internships: {count}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT id, username, role FROM users ORDER BY role, username";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateStatisticsReport();
        }

        private void GenerateStatisticsReport()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    string report = "=== INTERNSHIP TRACKER STATISTICS REPORT ===\n";
                    report += $"Generated on: {DateTime.Now:MM/dd/yyyy HH:mm}\n\n";

                    // Students by Major
                    report += "STUDENTS BY MAJOR:\n";
                    string query1 = "SELECT major, COUNT(*) as count FROM students GROUP BY major";
                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report += $"  {reader["major"]}: {reader["count"]}\n";
                        }
                    }

                    report += "\nAPPLICATIONS BY STATUS:\n";
                    string query2 = "SELECT status, COUNT(*) as count FROM applications GROUP BY status";
                    using (SqlCommand cmd = new SqlCommand(query2, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report += $"  {reader["status"]}: {reader["count"]}\n";
                        }
                    }

                    report += "\nTOP COMPANIES BY APPLICATIONS:\n";
                    string query3 = @"SELECT TOP 5 c.companyName, COUNT(a.id) as appCount 
                                    FROM companies c 
                                    LEFT JOIN internships i ON c.id = i.companyID 
                                    LEFT JOIN applications a ON i.id = a.internshipID 
                                    GROUP BY c.companyName 
                                    ORDER BY appCount DESC";
                    using (SqlCommand cmd = new SqlCommand(query3, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report += $"  {reader["companyName"]}: {reader["appCount"]}\n";
                        }
                    }

                    report += "\nUSERS BY ROLE:\n";
                    string query4 = "SELECT role, COUNT(*) as count FROM users GROUP BY role";
                    using (SqlCommand cmd = new SqlCommand(query4, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            report += $"  {reader["role"]}: {reader["count"]}\n";
                        }
                    }

                    // Show report
                    ReportViewerForm reportViewer = new ReportViewerForm(report);
                    reportViewer.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!UserSession.IsLoggedIn())
            {
                Application.Exit();
            }
        }
    }
}