using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class ViewApplicationDetailsForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;

        private DataTable dt = new DataTable();
        private int currentRow = 0;

        private GroupBox gbHeader;
        private Label lblIDLabel;
        private TextBox txtID;
        private Label lblStudentIDLabel;
        private TextBox txtStudentID;
        private Label lblInternshipIDLabel;
        private TextBox txtInternshipID;
        private Label lblResumeLabel;
        private TextBox txtResume;
        private Label lblStatusLabel;
        private TextBox txtStatus;
        private Label lblSubmissionDateLabel;
        private TextBox txtSubmissionDate;
        private Button btnDecline;
        private Button btnAccept;
        private Button btnPrevious;
        private Button btnNext;

        public ViewApplicationDetailsForm()
        {
            InitializeComponent();
            LoadApplications();
            if (dt.Rows.Count > 0)
            {
                currentRow = 0;
                DisplayInformation();
            }
            else
            {
                MessageBox.Show("No applications to review.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InitializeComponent()
        {
            this.gbHeader = new GroupBox();
            this.lblIDLabel = new Label();
            this.txtID = new TextBox();
            this.lblStudentIDLabel = new Label();
            this.txtStudentID = new TextBox();
            this.lblInternshipIDLabel = new Label();
            this.txtInternshipID = new TextBox();
            this.lblResumeLabel = new Label();
            this.txtResume = new TextBox();
            this.lblStatusLabel = new Label();
            this.txtStatus = new TextBox();
            this.lblSubmissionDateLabel = new Label();
            this.txtSubmissionDate = new TextBox();
            this.btnDecline = new Button();
            this.btnAccept = new Button();
            this.btnPrevious = new Button();
            this.btnNext = new Button();

            this.SuspendLayout();

            // Form
            this.BackColor = BackgroundColor;

            // gbHeader
            this.gbHeader.BackColor = BackgroundColor;
            this.gbHeader.ForeColor = TextColor;
            this.gbHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.gbHeader.Location = new Point(20, 20);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new Size(760, 60);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Student Application";

            // lblIDLabel
            this.lblIDLabel.AutoSize = true;
            this.lblIDLabel.Font = new Font("Segoe UI", 9F);
            this.lblIDLabel.ForeColor = TextColor;
            this.lblIDLabel.Location = new Point(30, 100);
            this.lblIDLabel.Name = "lblIDLabel";
            this.lblIDLabel.Size = new Size(18, 15);
            this.lblIDLabel.TabIndex = 1;
            this.lblIDLabel.Text = "ID";

            // txtID
            this.txtID.BackColor = Color.FromArgb(40, 40, 40);
            this.txtID.ForeColor = TextColor;
            this.txtID.Font = new Font("Segoe UI", 10F);
            this.txtID.Location = new Point(30, 120);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new Size(200, 25);
            this.txtID.TabIndex = 2;
            this.txtID.BorderStyle = BorderStyle.FixedSingle;

            // lblStudentIDLabel
            this.lblStudentIDLabel.AutoSize = true;
            this.lblStudentIDLabel.Font = new Font("Segoe UI", 9F);
            this.lblStudentIDLabel.ForeColor = TextColor;
            this.lblStudentIDLabel.Location = new Point(290, 100);
            this.lblStudentIDLabel.Name = "lblStudentIDLabel";
            this.lblStudentIDLabel.Size = new Size(75, 15);
            this.lblStudentIDLabel.TabIndex = 3;
            this.lblStudentIDLabel.Text = "STUDENT ID";

            // txtStudentID
            this.txtStudentID.BackColor = Color.FromArgb(40, 40, 40);
            this.txtStudentID.ForeColor = TextColor;
            this.txtStudentID.Font = new Font("Segoe UI", 10F);
            this.txtStudentID.Location = new Point(290, 120);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new Size(200, 25);
            this.txtStudentID.TabIndex = 4;
            this.txtStudentID.BorderStyle = BorderStyle.FixedSingle;

            // lblInternshipIDLabel
            this.lblInternshipIDLabel.AutoSize = true;
            this.lblInternshipIDLabel.Font = new Font("Segoe UI", 9F);
            this.lblInternshipIDLabel.ForeColor = TextColor;
            this.lblInternshipIDLabel.Location = new Point(550, 100);
            this.lblInternshipIDLabel.Name = "lblInternshipIDLabel";
            this.lblInternshipIDLabel.Size = new Size(93, 15);
            this.lblInternshipIDLabel.TabIndex = 5;
            this.lblInternshipIDLabel.Text = "INTERNSHIP ID";

            // txtInternshipID
            this.txtInternshipID.BackColor = Color.FromArgb(40, 40, 40);
            this.txtInternshipID.ForeColor = TextColor;
            this.txtInternshipID.Font = new Font("Segoe UI", 10F);
            this.txtInternshipID.Location = new Point(550, 120);
            this.txtInternshipID.Name = "txtInternshipID";
            this.txtInternshipID.ReadOnly = true;
            this.txtInternshipID.Size = new Size(200, 25);
            this.txtInternshipID.TabIndex = 6;
            this.txtInternshipID.BorderStyle = BorderStyle.FixedSingle;

            // lblResumeLabel
            this.lblResumeLabel.AutoSize = true;
            this.lblResumeLabel.Font = new Font("Segoe UI", 9F);
            this.lblResumeLabel.ForeColor = TextColor;
            this.lblResumeLabel.Location = new Point(30, 170);
            this.lblResumeLabel.Name = "lblResumeLabel";
            this.lblResumeLabel.Size = new Size(53, 15);
            this.lblResumeLabel.TabIndex = 7;
            this.lblResumeLabel.Text = "RESUME";

            // txtResume
            this.txtResume.BackColor = Color.FromArgb(40, 40, 40);
            this.txtResume.ForeColor = TextColor;
            this.txtResume.Font = new Font("Segoe UI", 9F);
            this.txtResume.Location = new Point(30, 190);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.ReadOnly = true;
            this.txtResume.ScrollBars = ScrollBars.Vertical;
            this.txtResume.Size = new Size(720, 100);
            this.txtResume.TabIndex = 8;
            this.txtResume.BorderStyle = BorderStyle.FixedSingle;

            // lblStatusLabel
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Font = new Font("Segoe UI", 9F);
            this.lblStatusLabel.ForeColor = TextColor;
            this.lblStatusLabel.Location = new Point(30, 310);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new Size(48, 15);
            this.lblStatusLabel.TabIndex = 9;
            this.lblStatusLabel.Text = "STATUS";

            // txtStatus
            this.txtStatus.BackColor = Color.FromArgb(40, 40, 40);
            this.txtStatus.ForeColor = TextColor;
            this.txtStatus.Font = new Font("Segoe UI", 10F);
            this.txtStatus.Location = new Point(30, 330);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new Size(200, 25);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.BorderStyle = BorderStyle.FixedSingle;

            // lblSubmissionDateLabel
            this.lblSubmissionDateLabel.AutoSize = true;
            this.lblSubmissionDateLabel.Font = new Font("Segoe UI", 9F);
            this.lblSubmissionDateLabel.ForeColor = TextColor;
            this.lblSubmissionDateLabel.Location = new Point(550, 310);
            this.lblSubmissionDateLabel.Name = "lblSubmissionDateLabel";
            this.lblSubmissionDateLabel.Size = new Size(111, 15);
            this.lblSubmissionDateLabel.TabIndex = 11;
            this.lblSubmissionDateLabel.Text = "SUBMISSION DATE";

            // txtSubmissionDate
            this.txtSubmissionDate.BackColor = Color.FromArgb(40, 40, 40);
            this.txtSubmissionDate.ForeColor = TextColor;
            this.txtSubmissionDate.Font = new Font("Segoe UI", 10F);
            this.txtSubmissionDate.Location = new Point(550, 330);
            this.txtSubmissionDate.Name = "txtSubmissionDate";
            this.txtSubmissionDate.ReadOnly = true;
            this.txtSubmissionDate.Size = new Size(200, 25);
            this.txtSubmissionDate.TabIndex = 12;
            this.txtSubmissionDate.BorderStyle = BorderStyle.FixedSingle;

            // btnDecline
            this.btnDecline.BackColor = AccentColor;
            this.btnDecline.FlatStyle = FlatStyle.Flat;
            this.btnDecline.FlatAppearance.BorderSize = 0;
            this.btnDecline.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDecline.ForeColor = TextColor;
            this.btnDecline.Location = new Point(250, 385);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new Size(100, 35);
            this.btnDecline.TabIndex = 13;
            this.btnDecline.Text = "DECLINE";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Cursor = Cursors.Hand;
            this.btnDecline.Click += new EventHandler(this.DECLINE_Click);

            // btnAccept
            this.btnAccept.BackColor = AccentColor;
            this.btnAccept.FlatStyle = FlatStyle.Flat;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAccept.ForeColor = TextColor;
            this.btnAccept.Location = new Point(540, 385);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new Size(100, 35);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "ACCEPT";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Cursor = Cursors.Hand;
            this.btnAccept.Click += new EventHandler(this.ACCEPT_Click);

            // btnPrevious
            this.btnPrevious.BackColor = AccentColor;
            this.btnPrevious.FlatStyle = FlatStyle.Flat;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnPrevious.ForeColor = TextColor;
            this.btnPrevious.Location = new Point(100, 440);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new Size(110, 35);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "<PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Cursor = Cursors.Hand;
            this.btnPrevious.Click += new EventHandler(this.PREVIOUS_Click);

            // btnNext
            this.btnNext.BackColor = AccentColor;
            this.btnNext.FlatStyle = FlatStyle.Flat;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnNext.ForeColor = TextColor;
            this.btnNext.Location = new Point(580, 440);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new Size(110, 35);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "NEXT>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Cursor = Cursors.Hand;
            this.btnNext.Click += new EventHandler(this.NEXT_Click);

            // ViewApplicationDetailsForm
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.lblIDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblStudentIDLabel);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblInternshipIDLabel);
            this.Controls.Add(this.txtInternshipID);
            this.Controls.Add(this.lblResumeLabel);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.lblStatusLabel);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblSubmissionDateLabel);
            this.Controls.Add(this.txtSubmissionDate);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Name = "ViewApplicationDetailsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Application Details";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void DisplayInformation()
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            if (currentRow < 0 || currentRow >= dt.Rows.Count)
            {
                return;
            }

            txtID.Text = dt.Rows[currentRow]["id"].ToString();
            txtStudentID.Text = dt.Rows[currentRow]["studentID"].ToString();
            txtInternshipID.Text = dt.Rows[currentRow]["internshipID"].ToString();
            txtResume.Text = dt.Rows[currentRow]["resume"].ToString();
            txtStatus.Text = dt.Rows[currentRow]["status"].ToString();
            txtSubmissionDate.Text = Convert.ToDateTime(dt.Rows[currentRow]["submissionDate"]).ToString("MM/dd/yyyy");

            // Update form title to show current position
            this.Text = $"Application Details ({currentRow + 1} of {dt.Rows.Count})";
        }

        private void LoadApplications()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    // First get the company ID for this HR
                    string getCompanyQuery = "SELECT companyID FROM companyHR WHERE id = @hrId";
                    int companyId;

                    using (SqlCommand cmd = new SqlCommand(getCompanyQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@hrId", UserSession.ProfileId);
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Could not find company for this HR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        companyId = Convert.ToInt32(result);
                    }

                    // Now get all applications for this company's internships
                    string query = @"SELECT a.id, a.studentID, a.internshipID, a.resume, a.status, a.submissionDate 
                                   FROM applications a 
                                   INNER JOIN internships i ON a.internshipID = i.id 
                                   WHERE i.companyID = @companyID 
                                   AND (a.status = 'Pending' OR a.status LIKE 'Accepted%')
                                   ORDER BY a.submissionDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@companyID", companyId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DECLINE_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;

            DialogResult result = MessageBox.Show("Are you sure you want to decline this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int applicationId = Convert.ToInt32(dt.Rows[currentRow]["id"]);

                    using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                    {
                        conn.Open();
                        string query = "UPDATE applications SET status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", "Rejected");
                            cmd.Parameters.AddWithValue("@id", applicationId);

                            int updateResult = cmd.ExecuteNonQuery();

                            if (updateResult > 0)
                            {
                                MessageBox.Show("Application rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Remove from DataTable
                                dt.Rows[currentRow].Delete();
                                dt.AcceptChanges();

                                // Navigate to next/previous record
                                if (dt.Rows.Count == 0)
                                {
                                    MessageBox.Show("No more applications to review.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (currentRow >= dt.Rows.Count)
                                    {
                                        currentRow = dt.Rows.Count - 1;
                                    }
                                    DisplayInformation();
                                }
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
        }

        private void ACCEPT_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;

            int applicationId = Convert.ToInt32(dt.Rows[currentRow]["id"]);
            InternshipOffer offerForm = new InternshipOffer(applicationId);

            if (offerForm.ShowDialog() == DialogResult.OK)
            {
                // Remove from DataTable after accepting
                dt.Rows[currentRow].Delete();
                dt.AcceptChanges();

                // Navigate to next/previous record
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No more applications to review.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (currentRow >= dt.Rows.Count)
                    {
                        currentRow = dt.Rows.Count - 1;
                    }
                    DisplayInformation();
                }
            }
        }

        private void PREVIOUS_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;

            if (currentRow > 0)
            {
                currentRow--;
                DisplayInformation();
            }
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;

            if (currentRow < dt.Rows.Count - 1)
            {
                currentRow++;
                DisplayInformation();
            }
        }
    }
}