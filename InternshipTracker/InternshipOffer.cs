using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InternshipTracker
{
    public partial class InternshipOffer : Form
    {
        private static readonly Color BackgroundColor = ColorTranslator.FromHtml("#191919");
        private static readonly Color AccentColor = ColorTranslator.FromHtml("#2a84ff");
        private static readonly Color TextColor = Color.White;

        private int applicationId;

        public InternshipOffer(int applicationId)
        {
            this.applicationId = applicationId;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblDuration = new Label();
            this.Month_1 = new RadioButton();
            this.Month_3 = new RadioButton();
            this.Month_6 = new RadioButton();
            this.Months_12 = new RadioButton();
            this.Send_Offer = new Button();
            this.Cancel_Offer = new Button();

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
            this.lblTitle.Text = "Send Internship Offer";

            // lblDuration
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblDuration.ForeColor = TextColor;
            this.lblDuration.Location = new Point(30, 70);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new Size(180, 20);
            this.lblDuration.Text = "Select Internship Duration:";

            // Month_1
            this.Month_1.AutoSize = true;
            this.Month_1.Font = new Font("Segoe UI", 10F);
            this.Month_1.ForeColor = TextColor;
            this.Month_1.Location = new Point(50, 110);
            this.Month_1.Name = "Month_1";
            this.Month_1.Size = new Size(120, 23);
            this.Month_1.Text = "1 Month";
            this.Month_1.UseVisualStyleBackColor = true;

            // Month_3
            this.Month_3.AutoSize = true;
            this.Month_3.Font = new Font("Segoe UI", 10F);
            this.Month_3.ForeColor = TextColor;
            this.Month_3.Location = new Point(50, 145);
            this.Month_3.Name = "Month_3";
            this.Month_3.Size = new Size(120, 23);
            this.Month_3.Text = "3 Months";
            this.Month_3.UseVisualStyleBackColor = true;

            // Month_6
            this.Month_6.AutoSize = true;
            this.Month_6.Font = new Font("Segoe UI", 10F);
            this.Month_6.ForeColor = TextColor;
            this.Month_6.Location = new Point(50, 180);
            this.Month_6.Name = "Month_6";
            this.Month_6.Size = new Size(120, 23);
            this.Month_6.Text = "6 Months";
            this.Month_6.UseVisualStyleBackColor = true;

            // Months_12
            this.Months_12.AutoSize = true;
            this.Months_12.Font = new Font("Segoe UI", 10F);
            this.Months_12.ForeColor = TextColor;
            this.Months_12.Location = new Point(50, 215);
            this.Months_12.Name = "Months_12";
            this.Months_12.Size = new Size(120, 23);
            this.Months_12.Text = "12 Months";
            this.Months_12.UseVisualStyleBackColor = true;

            // Send_Offer
            this.Send_Offer.BackColor = AccentColor;
            this.Send_Offer.FlatStyle = FlatStyle.Flat;
            this.Send_Offer.FlatAppearance.BorderSize = 0;
            this.Send_Offer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Send_Offer.ForeColor = TextColor;
            this.Send_Offer.Location = new Point(120, 270);
            this.Send_Offer.Name = "Send_Offer";
            this.Send_Offer.Size = new Size(120, 35);
            this.Send_Offer.Text = "Send Offer";
            this.Send_Offer.Cursor = Cursors.Hand;
            this.Send_Offer.Click += new EventHandler(this.Send_Offer_Click);

            // Cancel_Offer
            this.Cancel_Offer.BackColor = AccentColor;
            this.Cancel_Offer.FlatStyle = FlatStyle.Flat;
            this.Cancel_Offer.FlatAppearance.BorderSize = 0;
            this.Cancel_Offer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Cancel_Offer.ForeColor = TextColor;
            this.Cancel_Offer.Location = new Point(250, 270);
            this.Cancel_Offer.Name = "Cancel_Offer";
            this.Cancel_Offer.Size = new Size(100, 35);
            this.Cancel_Offer.Text = "Cancel";
            this.Cancel_Offer.Cursor = Cursors.Hand;
            this.Cancel_Offer.Click += new EventHandler(this.Cancel_Offer_Click);

            // InternshipOffer
            this.ClientSize = new Size(400, 330);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.Month_1);
            this.Controls.Add(this.Month_3);
            this.Controls.Add(this.Month_6);
            this.Controls.Add(this.Months_12);
            this.Controls.Add(this.Send_Offer);
            this.Controls.Add(this.Cancel_Offer);
            this.Name = "InternshipOfferForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Send Internship Offer";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblDuration;
        private RadioButton Month_1;
        private RadioButton Month_3;
        private RadioButton Month_6;
        private RadioButton Months_12;
        private Button Send_Offer;
        private Button Cancel_Offer;

        private void Cancel_Offer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Send_Offer_Click(object sender, EventArgs e)
        {
            string status = "Potato";

            if (Month_1.Checked)
            {
                status = "Accepted. 1 Month Internship";
            }
            else if (Month_3.Checked)
            {
                status = "Accepted. 3 Month Internship";
            }
            else if (Month_6.Checked)
            {
                status = "Accepted. 6 Month Internship";
            }
            else if (Months_12.Checked)
            {
                status = "Accepted. 12 Month Internship";
            }
            else
            {
                MessageBox.Show("Please select an internship duration.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"UPDATE applications SET status = @status WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", applicationId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Offer Sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Send Offer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Rejecting Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
