using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class ViewStudentReportsForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;
       

        private int applicationId;

        public ViewStudentReportsForm(int applicationId)
        {
            this.applicationId = applicationId;
            InitializeComponent();
            LoadReports();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.dgvReports = new DataGridView();
            this.btnClose = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
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
            this.lblTitle.Text = "Student Progress Reports";

            // dgvReports
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.dgvReports.BorderStyle = BorderStyle.None;
            this.dgvReports.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
            this.dgvReports.ColumnHeadersDefaultCellStyle.ForeColor = TextColor;
            this.dgvReports.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvReports.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            this.dgvReports.DefaultCellStyle.ForeColor = TextColor;
            this.dgvReports.DefaultCellStyle.SelectionBackColor = AccentColor;
            this.dgvReports.DefaultCellStyle.SelectionForeColor = TextColor;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.GridColor = Color.FromArgb(60, 60, 60);
            this.dgvReports.Location = new Point(20, 70);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new Size(760, 400);

            // btnClose
            this.btnClose.BackColor = AccentColor;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClose.ForeColor = TextColor;
            this.btnClose.Location = new Point(680, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 35);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ViewStudentReportsForm
            this.ClientSize = new Size(800, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnClose);
            this.Name = "ViewStudentReportsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Student Reports";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private DataGridView dgvReports;
        private Button btnClose;

        private void LoadReports()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT reportDate, hoursWorked, activities, learnings 
                                   FROM reports 
                                   WHERE applicationID = @applicationID
                                   ORDER BY reportDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@applicationID", applicationId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No reports found for this application.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            dgvReports.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}