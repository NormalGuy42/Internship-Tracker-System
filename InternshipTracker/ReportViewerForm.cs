using System;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class ReportViewerForm : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;

        private string reportContent;

        public ReportViewerForm(string reportContent)
        {
            this.reportContent = reportContent;
            InitializeComponent();
            LoadReport();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.txtReport = new TextBox();
            this.btnClose = new Button();

            this.SuspendLayout();

            // Form
            this.BackColor = BackgroundColor;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = AccentColor;
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(250, 30);
            this.lblTitle.Text = "Statistics Report";

            // txtReport
            this.txtReport.BackColor = Color.FromArgb(40, 40, 40);
            this.txtReport.ForeColor = TextColor;
            this.txtReport.Font = new Font("Consolas", 10F);
            this.txtReport.Location = new Point(20, 70);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.ScrollBars = ScrollBars.Both;
            this.txtReport.Size = new Size(760, 450);
            this.txtReport.BorderStyle = BorderStyle.FixedSingle;
            this.txtReport.WordWrap = false;

            // btnClose
            this.btnClose.BackColor = AccentColor;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClose.ForeColor = TextColor;
            this.btnClose.Location = new Point(680, 535);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 35);
            this.btnClose.Text = "Close";
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ReportViewerForm
            this.ClientSize = new Size(800, 590);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnClose);
            this.Name = "ReportViewerForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Report Viewer";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private TextBox txtReport;
        private Button btnClose;

        private void LoadReport()
        {
            txtReport.Text = reportContent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}