using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class EvaluationForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
        

        private int applicationId;

        public EvaluationForm(int applicationId)
        {
            this.applicationId = applicationId;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblPerformance = new Label();
            this.numPerformance = new NumericUpDown();
            this.lblPunctuality = new Label();
            this.numPunctuality = new NumericUpDown();
            this.lblCommunication = new Label();
            this.numCommunication = new NumericUpDown();
            this.lblComments = new Label();
            this.txtComments = new TextBox();
            this.btnSubmit = new Button();
            this.btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.numPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPunctuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommunication)).BeginInit();
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
            this.lblTitle.Text = "Student Evaluation";

            // lblPerformance
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new Font("Segoe UI", 10F);
            this.lblPerformance.ForeColor = TextColor;
            this.lblPerformance.Location = new Point(30, 80);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new Size(170, 19);
            this.lblPerformance.Text = "Performance Score (1-10):";

            // numPerformance
            this.numPerformance.BackColor = Color.FromArgb(40, 40, 40);
            this.numPerformance.ForeColor = TextColor;
            this.numPerformance.Font = new Font("Segoe UI", 10F);
            this.numPerformance.Location = new Point(220, 78);
            this.numPerformance.Maximum = 10;
            this.numPerformance.Minimum = 1;
            this.numPerformance.Name = "numPerformance";
            this.numPerformance.Size = new Size(80, 25);
            this.numPerformance.Value = 5;

            // lblPunctuality
            this.lblPunctuality.AutoSize = true;
            this.lblPunctuality.Font = new Font("Segoe UI", 10F);
            this.lblPunctuality.ForeColor = TextColor;
            this.lblPunctuality.Location = new Point(30, 120);
            this.lblPunctuality.Name = "lblPunctuality";
            this.lblPunctuality.Size = new Size(170, 19);
            this.lblPunctuality.Text = "Punctuality Score (1-10):";

            // numPunctuality
            this.numPunctuality.BackColor = Color.FromArgb(40, 40, 40);
            this.numPunctuality.ForeColor = TextColor;
            this.numPunctuality.Font = new Font("Segoe UI", 10F);
            this.numPunctuality.Location = new Point(220, 118);
            this.numPunctuality.Maximum = 10;
            this.numPunctuality.Minimum = 1;
            this.numPunctuality.Name = "numPunctuality";
            this.numPunctuality.Size = new Size(80, 25);
            this.numPunctuality.Value = 5;

            // lblCommunication
            this.lblCommunication.AutoSize = true;
            this.lblCommunication.Font = new Font("Segoe UI", 10F);
            this.lblCommunication.ForeColor = TextColor;
            this.lblCommunication.Location = new Point(30, 160);
            this.lblCommunication.Name = "lblCommunication";
            this.lblCommunication.Size = new Size(190, 19);
            this.lblCommunication.Text = "Communication Score (1-10):";

            // numCommunication
            this.numCommunication.BackColor = Color.FromArgb(40, 40, 40);
            this.numCommunication.ForeColor = TextColor;
            this.numCommunication.Font = new Font("Segoe UI", 10F);
            this.numCommunication.Location = new Point(230, 158);
            this.numCommunication.Maximum = 10;
            this.numCommunication.Minimum = 1;
            this.numCommunication.Name = "numCommunication";
            this.numCommunication.Size = new Size(80, 25);
            this.numCommunication.Value = 5;

            // lblComments
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new Font("Segoe UI", 10F);
            this.lblComments.ForeColor = TextColor;
            this.lblComments.Location = new Point(30, 210);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new Size(80, 19);
            this.lblComments.Text = "Comments:";

            // txtComments
            this.txtComments.BackColor = Color.FromArgb(40, 40, 40);
            this.txtComments.ForeColor = TextColor;
            this.txtComments.Font = new Font("Segoe UI", 9F);
            this.txtComments.Location = new Point(30, 235);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = ScrollBars.Vertical;
            this.txtComments.Size = new Size(440, 120);
            this.txtComments.BorderStyle = BorderStyle.FixedSingle;

            // btnSubmit
            this.btnSubmit.BackColor = AccentColor;
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSubmit.ForeColor = TextColor;
            this.btnSubmit.Location = new Point(250, 375);
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
            this.btnCancel.Location = new Point(370, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // EvaluationForm
            this.ClientSize = new Size(500, 430);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPerformance);
            this.Controls.Add(this.numPerformance);
            this.Controls.Add(this.lblPunctuality);
            this.Controls.Add(this.numPunctuality);
            this.Controls.Add(this.lblCommunication);
            this.Controls.Add(this.numCommunication);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "EvaluationForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Student Evaluation";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            ((System.ComponentModel.ISupportInitialize)(this.numPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPunctuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommunication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblPerformance;
        private NumericUpDown numPerformance;
        private Label lblPunctuality;
        private NumericUpDown numPunctuality;
        private Label lblCommunication;
        private NumericUpDown numCommunication;
        private Label lblComments;
        private TextBox txtComments;
        private Button btnSubmit;
        private Button btnCancel;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO evaluations (applicationID, supervisorID, evaluationDate, 
                                   performanceScore, punctualityScore, communicationScore, comments) 
                                   VALUES (@applicationID, @supervisorID, @evaluationDate, 
                                   @performanceScore, @punctualityScore, @communicationScore, @comments)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@applicationID", applicationId);
                        cmd.Parameters.AddWithValue("@supervisorID", UserSession.ProfileId);
                        cmd.Parameters.AddWithValue("@evaluationDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@performanceScore", (int)numPerformance.Value);
                        cmd.Parameters.AddWithValue("@punctualityScore", (int)numPunctuality.Value);
                        cmd.Parameters.AddWithValue("@communicationScore", (int)numCommunication.Value);
                        cmd.Parameters.AddWithValue("@comments", string.IsNullOrWhiteSpace(txtComments.Text) ? (object)DBNull.Value : txtComments.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Evaluation submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit evaluation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting evaluation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
