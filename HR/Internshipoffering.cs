using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class InternshipOffer : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madiou\source\repos\InternshipTracker\InternshipTracker\db.mdff;Integrated Security=True";
        public InternshipOffer()
        {
            InitializeComponent();
        }

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
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE applications SET status = @status";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);

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