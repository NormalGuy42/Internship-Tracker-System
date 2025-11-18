using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class CreateInternshipForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
        

        public CreateInternshipForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblJobTitle = new Label();
            this.txtJobTitle = new TextBox();
            this.lblDescription = new Label();
            this.txtDescription = new TextBox();
            this.lblRequirements = new Label();
            this.txtRequirements = new TextBox();
            this.lblDeadline = new Label();
            this.dtpDeadline = new DateTimePicker();
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
            this.lblTitle.Size = new Size(280, 30);
            this.lblTitle.Text = "Create Internship Post";

            // lblJobTitle
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new Font("Segoe UI", 10F);
            this.lblJobTitle.ForeColor = TextColor;
            this.lblJobTitle.Location = new Point(30, 70);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new Size(70, 19);
            this.lblJobTitle.Text = "Job Title:";

            // txtJobTitle
            this.txtJobTitle.BackColor = Color.FromArgb(40, 40, 40);
            this.txtJobTitle.ForeColor = TextColor;
            this.txtJobTitle.Font = new Font("Segoe UI", 10F);
            this.txtJobTitle.Location = new Point(30, 95);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new Size(540, 25);
            this.txtJobTitle.BorderStyle = BorderStyle.FixedSingle;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = TextColor;
            this.lblDescription.Location = new Point(30, 135);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(85, 19);
            this.lblDescription.Text = "Description:";

            // txtDescription
            this.txtDescription.BackColor = Color.FromArgb(40, 40, 40);
            this.txtDescription.ForeColor = TextColor;
            this.txtDescription.Font = new Font("Segoe UI", 9F);
            this.txtDescription.Location = new Point(30, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = ScrollBars.Vertical;
            this.txtDescription.Size = new Size(540, 80);
            this.txtDescription.BorderStyle = BorderStyle.FixedSingle;

            // lblRequirements
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Font = new Font("Segoe UI", 10F);
            this.lblRequirements.ForeColor = TextColor;
            this.lblRequirements.Location = new Point(30, 255);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new Size(100, 19);
            this.lblRequirements.Text = "Requirements:";

            // txtRequirements
            this.txtRequirements.BackColor = Color.FromArgb(40, 40, 40);
            this.txtRequirements.ForeColor = TextColor;
            this.txtRequirements.Font = new Font("Segoe UI", 9F);
            this.txtRequirements.Location = new Point(30, 280);
            this.txtRequirements.Multiline = true;
            this.txtRequirements.Name = "txtRequirements";
            this.txtRequirements.ScrollBars = ScrollBars.Vertical;
            this.txtRequirements.Size = new Size(540, 80);
            this.txtRequirements.BorderStyle = BorderStyle.FixedSingle;

            // lblDeadline
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new Font("Segoe UI", 10F);
            this.lblDeadline.ForeColor = TextColor;
            this.lblDeadline.Location = new Point(30, 375);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new Size(140, 19);
            this.lblDeadline.Text = "Application Deadline:";

            // dtpDeadline
            this.dtpDeadline.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            this.dtpDeadline.CalendarForeColor = TextColor;
            this.dtpDeadline.Font = new Font("Segoe UI", 10F);
            this.dtpDeadline.Location = new Point(30, 400);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new Size(250, 25);

            // btnCreate
            this.btnCreate.BackColor = AccentColor;
            this.btnCreate.FlatStyle = FlatStyle.Flat;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCreate.ForeColor = TextColor;
            this.btnCreate.Location = new Point(350, 450);
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
            this.btnCancel.Location = new Point(470, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(100, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // CreateInternshipForm
            this.ClientSize = new Size(600, 510);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblRequirements);
            this.Controls.Add(this.txtRequirements);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateInternshipForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Create Internship";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblJobTitle;
        private TextBox txtJobTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblRequirements;
        private TextBox txtRequirements;
        private Label lblDeadline;
        private DateTimePicker dtpDeadline;
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

                    // Get the company ID for this HR
                    string getCompanyQuery = "SELECT companyID FROM companyHR WHERE id = @hrId";
                    int companyId;

                    using (SqlCommand cmd = new SqlCommand(getCompanyQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@hrId", UserSession.ProfileId);
                        companyId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insert the internship
                    string query = @"INSERT INTO internships (companyID, title, description, requirements, deadline, isActive) 
                                   VALUES (@companyID, @title, @description, @requirements, @deadline, 1)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@companyID", companyId);
                        cmd.Parameters.AddWithValue("@title", txtJobTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@requirements", txtRequirements.Text.Trim());
                        cmd.Parameters.AddWithValue("@deadline", dtpDeadline.Value);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Internship created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create internship.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating internship: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Please enter a job title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRequirements.Text))
            {
                MessageBox.Show("Please enter requirements.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequirements.Focus();
                return false;
            }

            if (dtpDeadline.Value <= DateTime.Now)
            {
                MessageBox.Show("Deadline must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDeadline.Focus();
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
