using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class SupervisorDashboard : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;

        public SupervisorDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblActiveInternships = new Label();
            this.dgvActiveInternships = new DataGridView();
            this.btnEvaluate = new Button();
            this.btnViewReports = new Button();
            this.btnLogout = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveInternships)).BeginInit();
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
            this.lblTitle.Text = "Supervisor Dashboard";

            // lblActiveInternships
            this.lblActiveInternships.AutoSize = true;
            this.lblActiveInternships.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblActiveInternships.ForeColor = TextColor;
            this.lblActiveInternships.Location = new Point(20, 70);
            this.lblActiveInternships.Name = "lblActiveInternships";
            this.lblActiveInternships.Size = new Size(250, 20);
            this.lblActiveInternships.Text = "Active Student Internships";

            // dgvActiveInternships
            this.dgvActiveInternships.AllowUserToAddRows = false;
            this.dgvActiveInternships.AllowUserToDeleteRows = false;
            this.dgvActiveInternships.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvActiveInternships.BorderStyle = BorderStyle.None;
            this.dgvActiveInternships.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
            this.dgvActiveInternships.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            this.dgvActiveInternships.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvActiveInternships.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            this.dgvActiveInternships.DefaultCellStyle.ForeColor = TextColor;
            this.dgvActiveInternships.DefaultCellStyle.SelectionBackColor = AccentColor;
            this.dgvActiveInternships.DefaultCellStyle.SelectionForeColor = TextColor;
            this.dgvActiveInternships.EnableHeadersVisualStyles = false;
            this.dgvActiveInternships.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvActiveInternships.Location = new Point(20, 100);
            this.dgvActiveInternships.Name = "dgvActiveInternships";
            this.dgvActiveInternships.ReadOnly = true;
            this.dgvActiveInternships.RowHeadersVisible = false;
            this.dgvActiveInternships.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveInternships.Size = new Size(960, 450);

            // btnEvaluate
            this.btnEvaluate.BackColor = AccentColor;
            this.btnEvaluate.FlatStyle = FlatStyle.Flat;
            this.btnEvaluate.FlatAppearance.BorderSize = 0;
            this.btnEvaluate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnEvaluate.ForeColor = TextColor;
            this.btnEvaluate.Location = new Point(640, 565);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new Size(150, 35);
            this.btnEvaluate.Text = "Evaluate Student";
            this.btnEvaluate.Cursor = Cursors.Hand;
            this.btnEvaluate.Click += new EventHandler(this.btnEvaluate_Click);

            // btnViewReports
            this.btnViewReports.BackColor = AccentColor;
            this.btnViewReports.FlatStyle = FlatStyle.Flat;
            this.btnViewReports.FlatAppearance.BorderSize = 0;
            this.btnViewReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnViewReports.ForeColor = TextColor;
            this.btnViewReports.Location = new Point(640, 610);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new Size(150, 35);
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.Cursor = Cursors.Hand;
            this.btnViewReports.Click += new EventHandler(this.btnViewReports_Click);

            // btnLogout
            this.btnLogout.BackColor = AccentColor;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = TextColor;
            this.btnLogout.Location = new Point(880, 610);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(100, 35);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // SupervisorDashboard
            this.ClientSize = new Size(1000, 660);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblActiveInternships);
            this.Controls.Add(this.dgvActiveInternships);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnLogout);
            this.Name = "SupervisorDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Supervisor Dashboard - Internship Tracker";
            this.FormClosed += new FormClosedEventHandler(this.SupervisorDashboard_FormClosed);

            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveInternships)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblActiveInternships;
        private DataGridView dgvActiveInternships;
        private Button btnEvaluate;
        private Button btnViewReports;
        private Button btnLogout;

        private void LoadData()
        {
            LoadActiveInternships();
        }

        private void LoadActiveInternships()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT a.id, s.firstName + ' ' + s.lastName as StudentName, 
                                   c.companyName, i.title as InternshipTitle, a.status, a.submissionDate
                                   FROM applications a
                                   INNER JOIN students s ON a.studentID = s.id
                                   INNER JOIN internships i ON a.internshipID = i.id
                                   INNER JOIN companies c ON i.companyID = c.id
                                   WHERE a.status LIKE 'Accepted%'
                                   ORDER BY a.submissionDate DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvActiveInternships.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading internships: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if (dgvActiveInternships.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to evaluate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int applicationId = Convert.ToInt32(dgvActiveInternships.SelectedRows[0].Cells["id"].Value);
            EvaluationForm evalForm = new EvaluationForm(applicationId);
            if (evalForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            if (dgvActiveInternships.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to view reports.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int applicationId = Convert.ToInt32(dgvActiveInternships.SelectedRows[0].Cells["id"].Value);
            ViewStudentReportsForm reportsForm = new ViewStudentReportsForm(applicationId);
            reportsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void SupervisorDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!UserSession.IsLoggedIn())
            {
                Application.Exit();
            }
        }
    }
}