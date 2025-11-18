using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class CompanyHRDashboard : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;

        public CompanyHRDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblMyInternships = new Label();
            this.dgvMyInternships = new DataGridView();
            this.btnCreateInternship = new Button();
            this.lblApplications = new Label();
            this.dgvApplications = new DataGridView();
            this.btnViewApplication = new Button();
            this.btnSendOffer = new Button();
            this.btnReject = new Button();
            this.btnLogout = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMyInternships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();

            // Form
            this.BackColor = BackgroundColor;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = AccentColor;
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(300, 30);
            this.lblTitle.Text = "Company HR Dashboard";

            // lblMyInternships
            this.lblMyInternships.AutoSize = true;
            this.lblMyInternships.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblMyInternships.ForeColor = TextColor;
            this.lblMyInternships.Location = new Point(20, 70);
            this.lblMyInternships.Name = "lblMyInternships";
            this.lblMyInternships.Size = new Size(150, 20);
            this.lblMyInternships.Text = "My Internship Posts";

            // dgvMyInternships
            this.dgvMyInternships.AllowUserToAddRows = false;
            this.dgvMyInternships.AllowUserToDeleteRows = false;
            this.dgvMyInternships.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvMyInternships.BorderStyle = BorderStyle.None;
            this.dgvMyInternships.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
            this.dgvMyInternships.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            this.dgvMyInternships.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvMyInternships.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            this.dgvMyInternships.DefaultCellStyle.ForeColor = TextColor;
            this.dgvMyInternships.DefaultCellStyle.SelectionBackColor = AccentColor;
            this.dgvMyInternships.DefaultCellStyle.SelectionForeColor = TextColor;
            this.dgvMyInternships.EnableHeadersVisualStyles = false;
            this.dgvMyInternships.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvMyInternships.Location = new Point(20, 100);
            this.dgvMyInternships.Name = "dgvMyInternships";
            this.dgvMyInternships.ReadOnly = true;
            this.dgvMyInternships.RowHeadersVisible = false;
            this.dgvMyInternships.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyInternships.Size = new Size(960, 180);

            // btnCreateInternship
            this.btnCreateInternship.BackColor = AccentColor;
            this.btnCreateInternship.FlatStyle = FlatStyle.Flat;
            this.btnCreateInternship.FlatAppearance.BorderSize = 0;
            this.btnCreateInternship.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCreateInternship.ForeColor = TextColor;
            this.btnCreateInternship.Location = new Point(820, 290);
            this.btnCreateInternship.Name = "btnCreateInternship";
            this.btnCreateInternship.Size = new Size(160, 35);
            this.btnCreateInternship.Text = "Create Internship";
            this.btnCreateInternship.Cursor = Cursors.Hand;
            this.btnCreateInternship.Click += new EventHandler(this.btnCreateInternship_Click);

            // lblApplications
            this.lblApplications.AutoSize = true;
            this.lblApplications.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblApplications.ForeColor = TextColor;
            this.lblApplications.Location = new Point(20, 340);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new Size(180, 20);
            this.lblApplications.Text = "Student Applications";

            // dgvApplications
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvApplications.BorderStyle = BorderStyle.None;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvApplications.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            this.dgvApplications.DefaultCellStyle.ForeColor = TextColor;
            this.dgvApplications.DefaultCellStyle.SelectionBackColor = AccentColor;
            this.dgvApplications.DefaultCellStyle.SelectionForeColor = TextColor;
            this.dgvApplications.EnableHeadersVisualStyles = false;
            this.dgvApplications.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvApplications.Location = new Point(20, 370);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new Size(960, 180);

            // btnViewApplication
            this.btnViewApplication.BackColor = AccentColor;
            this.btnViewApplication.FlatStyle = FlatStyle.Flat;
            this.btnViewApplication.FlatAppearance.BorderSize = 0;
            this.btnViewApplication.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnViewApplication.ForeColor = TextColor;
            this.btnViewApplication.Location = new Point(550, 560);
            this.btnViewApplication.Name = "btnViewApplication";
            this.btnViewApplication.Size = new Size(130, 35);
            this.btnViewApplication.Text = "View Details";
            this.btnViewApplication.Cursor = Cursors.Hand;
            this.btnViewApplication.Click += new EventHandler(this.btnViewApplication_Click);

            // btnSendOffer
            this.btnSendOffer.BackColor = AccentColor;
            this.btnSendOffer.FlatStyle = FlatStyle.Flat;
            this.btnSendOffer.FlatAppearance.BorderSize = 0;
            this.btnSendOffer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSendOffer.ForeColor = TextColor;
            this.btnSendOffer.Location = new Point(690, 560);
            this.btnSendOffer.Name = "btnSendOffer";
            this.btnSendOffer.Size = new Size(130, 35);
            this.btnSendOffer.Text = "Send Offer";
            this.btnSendOffer.Cursor = Cursors.Hand;
            this.btnSendOffer.Click += new EventHandler(this.btnSendOffer_Click);

            // btnReject
            this.btnReject.BackColor = AccentColor;
            this.btnReject.FlatStyle = FlatStyle.Flat;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnReject.ForeColor = TextColor;
            this.btnReject.Location = new Point(830, 560);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new Size(150, 35);
            this.btnReject.Text = "Reject Application";
            this.btnReject.Cursor = Cursors.Hand;
            this.btnReject.Click += new EventHandler(this.btnReject_Click);

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

            // CompanyHRDashboard
            this.ClientSize = new Size(1000, 660);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMyInternships);
            this.Controls.Add(this.dgvMyInternships);
            this.Controls.Add(this.btnCreateInternship);
            this.Controls.Add(this.lblApplications);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.btnViewApplication);
            this.Controls.Add(this.btnSendOffer);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnLogout);
            this.Name = "CompanyHRDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Company HR Dashboard - Internship Tracker";
            this.FormClosed += new FormClosedEventHandler(this.CompanyHRDashboard_FormClosed);

            ((System.ComponentModel.ISupportInitialize)(this.dgvMyInternships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblMyInternships;
        private Label lblApplications;
        private DataGridView dgvMyInternships;
        private DataGridView dgvApplications;
        private Button btnCreateInternship;
        private Button btnViewApplication;
        private Button btnSendOffer;
        private Button btnReject;
        private Button btnLogout;

        private void LoadData()
        {
            LoadMyInternships();
            LoadApplications();
        }

        private void LoadMyInternships()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT i.id, i.title, i.deadline, i.isActive,
                                   (SELECT COUNT(*) FROM applications WHERE internshipID = i.id) as ApplicationCount
                                   FROM internships i
                                   INNER JOIN companies c ON i.companyID = c.id
                                   INNER JOIN companyHR hr ON hr.companyID = c.id
                                   WHERE hr.id = @hrId
                                   ORDER BY i.deadline DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hrId", UserSession.ProfileId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvMyInternships.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading internships: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadApplications()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT a.id, s.firstName + ' ' + s.lastName as StudentName, 
                                   i.title as InternshipTitle, a.status, a.submissionDate
                                   FROM applications a
                                   INNER JOIN students s ON a.studentID = s.id
                                   INNER JOIN internships i ON a.internshipID = i.id
                                   INNER JOIN companies c ON i.companyID = c.id
                                   INNER JOIN companyHR hr ON hr.companyID = c.id
                                   WHERE hr.id = @hrId
                                   ORDER BY a.submissionDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hrId", UserSession.ProfileId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvApplications.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateInternship_Click(object sender, EventArgs e)
        {
            CreateInternshipForm createForm = new CreateInternshipForm();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadMyInternships();
            }
        }

        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            ViewApplicationDetailsForm viewForm = new ViewApplicationDetailsForm();
            if (viewForm.ShowDialog() == DialogResult.OK)
            {
                LoadApplications();
            }
        }

        private void btnSendOffer_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int applicationId = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["id"].Value);
            InternshipOffer offerForm = new InternshipOffer(applicationId);
            if (offerForm.ShowDialog() == DialogResult.OK)
            {
                LoadApplications();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application to reject.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to reject this application?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int applicationId = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["id"].Value);
                RejectApplication(applicationId);
            }
        }

        private void RejectApplication(int applicationId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE applications SET status = @status WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", "Rejected");
                        cmd.Parameters.AddWithValue("@id", applicationId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Application rejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadApplications();
                        }
                        else
                        {
                            MessageBox.Show("Failed to reject application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rejecting application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void CompanyHRDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!UserSession.IsLoggedIn())
            {
                Application.Exit();
            }
        }
    }
}