using InternshipTracker;
using System.Data;
using System.Data.SqlClient;

namespace HR
{
    public partial class HR : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madiou\source\repos\InternshipTracker\InternshipTracker\db.mdff;Integrated Security=True";

        private DataTable dt = new DataTable();

        private int currentRow = 0;

        public HR()
        {
            InitializeComponent();
            LoadAvailableInternships();
        }

        private void DisplayInformation()
        {
            ID.Text = dt.Rows[currentRow]["id"].ToString();
            STUDENT_ID.Text = dt.Rows[currentRow]["studentID"].ToString();
            INTERNSHIP_ID.Text = dt.Rows[currentRow]["internshipID"].ToString();
            RESUME.Text = dt.Rows[currentRow]["resume"].ToString();
            Status.Text = dt.Rows[currentRow]["status"].ToString();
            Submission_Date.Text = dt.Rows[currentRow]["submissionDate"].ToString();
        }

        private void LoadAvailableInternships()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT a.id, i.studentID, i.internshipID, a.resume, a.status, a.submissionDate 
                                   FROM applications a 
                                   INNER JOIN internships i ON a.internshipID = i.id AND students s ON a.studentID = s.id
                                   WHERE a.status = 'Pending' OR a.status = 'Accepted'";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading internships: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DECLINE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE applications SET status = @status";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", "Rejected");

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Application rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            dt.AcceptChanges();
                            foreach (DataRow row in dt.Rows)
                            {
                                if (dt.Rows.IndexOf(row) == currentRow)
                                {
                                    row.Delete();
                                }
                            }
                            if (currentRow < dt.Rows.Count - 1)
                            {
                                currentRow++;
                            }
                            else if (currentRow > 0)
                            {
                                currentRow--;
                            }
                            DisplayInformation();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Reject application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Rejecting Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ACCEPT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE applications SET status = @status";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", "Accepted");

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Application Acccepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            dt.AcceptChanges();
                            foreach (DataRow row in dt.Rows)
                            {
                                if (dt.Rows.IndexOf(row) == currentRow)
                                {
                                    InternshipOffer offer = new InternshipOffer();
                                    offer.ShowDialog();
                                }
}
                            if (currentRow < dt.Rows.Count - 1)
                            {
                                currentRow++;
                            }
                            else if (currentRow > 0)
                            {
                                currentRow--;
                            }
                            DisplayInformation();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Accept application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Accepting Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            if (currentRow < dt.Rows.Count - 1)
            {
                currentRow++;
                DisplayInformation();
            }
        }

        private void PREVIOUS_Click(object sender, EventArgs e)
        {
            if (currentRow > 0)
            {
                currentRow--;
                DisplayInformation();
            }
        }
    }
}
