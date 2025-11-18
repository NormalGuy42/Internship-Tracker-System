using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class ApplicationForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
       

        private int internshipId;
        private int studentId;

        public ApplicationForm(int internshipId, int studentId)
        {
            this.internshipId = internshipId;
            this.studentId = studentId;
            InitializeComponent();
            LoadInternshipDetails();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblInternshipInfo = new Label();
            this.txtInternshipInfo = new TextBox();
            this.lblResume = new Label();
            this.txtResume = new TextBox();
            this.lblCoverLetter = new Label();
            this.txtCoverLetter = new TextBox();
            this.btnSubmit = new Button();
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
            this.lblTitle.Size = new Size(300, 30);
            this.lblTitle.Text = "Apply for Internship";

            // lblInternshipInfo
            this.lblInternshipInfo.AutoSize = true;
            this.lblInternshipInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblInternshipInfo.ForeColor = TextColor;
            this.lblInternshipInfo.Location = new Point(30, 70);
            this.lblInternshipInfo.Name = "lblInternshipInfo";
            this.lblInternshipInfo.Size = new Size(150, 19);
            this.lblInternshipInfo.Text = "Internship Details:";

            // txtInternshipInfo
            this.txtInternshipInfo.BackColor = Color.FromArgb(40, 40, 40);
            this.txtInternshipInfo.ForeColor = TextColor;
            this.txtInternshipInfo.Font = new Font("Segoe UI", 9F);
            this.txtInternshipInfo.Location = new Point(30, 95);
            this.txtInternshipInfo.Multiline = true;
            this.txtInternshipInfo.Name = "txtInternshipInfo";
            this.txtInternshipInfo.ReadOnly = true;
            this.txtInternshipInfo.ScrollBars = ScrollBars.Vertical;
            this.txtInternshipInfo.Size = new Size(540, 80);
            this.txtInternshipInfo.BorderStyle = BorderStyle.FixedSingle;

            // lblResume
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblResume.ForeColor = TextColor;
            this.lblResume.Location = new Point(30, 190);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new Size(250, 19);
            this.lblResume.Text = "Resume/CV (paste text or link):";

            // txtResume
            this.txtResume.BackColor = Color.FromArgb(40, 40, 40);
            this.txtResume.ForeColor = TextColor;
            this.txtResume.Font = new Font("Segoe UI", 9F);
            this.txtResume.Location = new Point(30, 215);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.ScrollBars = ScrollBars.Vertical;
            this.txtResume.Size = new Size(540, 100);
            this.txtResume.BorderStyle = BorderStyle.FixedSingle;

            // lblCoverLetter
            this.lblCoverLetter.AutoSize = true;
            this.lblCoverLetter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblCoverLetter.ForeColor = TextColor;
            this.lblCoverLetter.Location = new Point(30, 330);
            this.lblCoverLetter.Name = "lblCoverLetter";
            this.lblCoverLetter.Size = new Size(185, 19);
            this.lblCoverLetter.Text = "Cover Letter (Optional):";

            // txtCoverLetter
            this.txtCoverLetter.BackColor = Color.FromArgb(40, 40, 40);
            this.txtCoverLetter.ForeColor = TextColor;
            this.txtCoverLetter.Font = new Font("Segoe UI", 9F);
            this.txtCoverLetter.Location = new Point(30, 355);
            this.txtCoverLetter.Multiline = true;
            this.txtCoverLetter.Name = "txtCoverLetter";
            this.txtCoverLetter.ScrollBars = ScrollBars.Vertical;
            this.txtCoverLetter.Size = new Size(540, 120);
            this.txtCoverLetter.BorderStyle = BorderStyle.FixedSingle;

            // btnSubmit
            this.btnSubmit.BackColor = AccentColor;
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSubmit.ForeColor = TextColor;
            this.btnSubmit.Location = new Point(350, 495);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new Size(100, 35);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Cursor = Cursors.Hand;
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

            // btnCancel
            this.btnCancel.BackColor = AccentColor;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.ForeColor = TextColor;
            this.btnCancel.Location = new Point(470, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // ApplicationForm
            this.ClientSize = new Size(600, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInternshipInfo);
            this.Controls.Add(this.txtInternshipInfo);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.lblCoverLetter);
            this.Controls.Add(this.txtCoverLetter);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "ApplicationForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Apply for Internship";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblInternshipInfo;
        private TextBox txtInternshipInfo;
        private Label lblResume;
        private TextBox txtResume;
        private Label lblCoverLetter;
        private TextBox txtCoverLetter;
        private Button btnSubmit;
        private Button btnCancel;

        private void LoadInternshipDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT c.companyName, i.title, i.description, i.requirements, i.deadline 
                                   FROM internships i 
                                   INNER JOIN companies c ON i.companyID = c.id 
                                   WHERE i.id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", internshipId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string info = $"Company: {reader["companyName"]}\n";
                                info += $"Position: {reader["title"]}\n";
                                info += $"Deadline: {Convert.ToDateTime(reader["deadline"]).ToString("MM/dd/yyyy")}\n";
                                info += $"Description: {reader["description"]}\n";
                                info += $"Requirements: {reader["requirements"]}";

                                txtInternshipInfo.Text = info;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading internship details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (HasAlreadyApplied())
            {
                MessageBox.Show("You have already applied for this internship.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO applications (studentID, internshipID, resume, coverLetter, status, submissionDate) 
                                   VALUES (@studentID, @internshipID, @resume, @coverLetter, @status, @submissionDate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentId);
                        cmd.Parameters.AddWithValue("@internshipID", internshipId);
                        cmd.Parameters.AddWithValue("@resume", txtResume.Text.Trim());
                        cmd.Parameters.AddWithValue("@coverLetter", string.IsNullOrWhiteSpace(txtCoverLetter.Text) ? (object)DBNull.Value : txtCoverLetter.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Pending");
                        cmd.Parameters.AddWithValue("@submissionDate", DateTime.Now);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtResume.Text))
            {
                MessageBox.Show("Please enter your resume or provide a link to it.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResume.Focus();
                return false;
            }

            return true;
        }

        private bool HasAlreadyApplied()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM applications WHERE studentID = @studentID AND internshipID = @internshipID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", studentId);
                        cmd.Parameters.AddWithValue("@internshipID", internshipId);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}