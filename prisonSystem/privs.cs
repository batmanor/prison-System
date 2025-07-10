using System;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace prisonSystem
{
    public partial class privs : Form
    {
        public privs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.LoadData("select * from users", dataGridView1);
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            string username = idTextBox.Text.ToUpper();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            string role = "";
            if (prisonerRadioButton.Checked) role = "viewer_prisoner";
            else if (GuardRadioButton.Checked) role = "prison_admin";
            else if (viewerRadioButton.Checked) role = "viewer_guard";
            else if (jobRadioButton.Checked) role = "prison_HR";
            else
            {
                MessageBox.Show("please select a role to Revoke..");
                return;
            }
            OracleConnection connection = new OracleConnection(Main.connectionString);
            try
            {
                connection.Open();
                string grantQuery = "revoke " + role + " from :username";
                OracleCommand command = new OracleCommand(grantQuery, connection);
                command.Parameters.Add(new OracleParameter("username", username));

                command.ExecuteNonQuery();

                string updateQuery = "delete from users where username = :username and role = :role";
                OracleCommand cmd = new OracleCommand(updateQuery, connection);
                cmd.Parameters.Add(new OracleParameter("role", role));
                cmd.Parameters.Add(new OracleParameter("username", username));

                cmd.ExecuteNonQuery();

                MessageBox.Show("role updated!");
                Main.LoadData("select * from users where username = " + username, dataGridView1);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error :" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void privs_Load(object sender, EventArgs e)
        {
            Main.LoadData("select * from users", dataGridView1);
        }

        private void grantButton_Click(object sender, EventArgs e)
        {
            string query = "grant " + typeTextBox.Text + " on " + tableTextBox.Text + " to " + idTextBox.Text;
            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("privs granted!");
                    Main.LoadData("select * from users", dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("can't grant privs.\n\nError: " + ex);
                }

            }
        }

        private void revokeButton_Click(object sender, EventArgs e)
        {
            string query = "revoke " + typeTextBox.Text + " on " + tableTextBox.Text + " from " + idTextBox.Text;
            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                try
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("privs revoked!");
                    Main.LoadData("select * from users", dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("can't revoke.\n\nError: " + ex);
                }

            }
        }

        private void grantRoleButton_Click(object sender, EventArgs e)
        {
            string username = idTextBox.Text.ToUpper();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            string role = "";
            if (prisonerRadioButton.Checked) role = "VIEWER_PRISONER";
            else if (GuardRadioButton.Checked) role = "PRISON_ADMIN";
            else if (viewerRadioButton.Checked) role = "VIEWER_GUARD";
            else if (jobRadioButton.Checked) role = "PRISON_HR";
            else
            {
                MessageBox.Show("please select a role to grant...");
                return;
            }

            OracleConnection connection = new OracleConnection(Main.connectionString);
            try
            {
                connection.Open();
                string query = "grant " + role + " to :username";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter("username", username));
                command.ExecuteNonQuery();
                string updateQuery = "insert to users(username,role) values(:username,:role) WHERE username = :username";
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.Parameters.Add(new OracleParameter("role", role));
                cmd.Parameters.Add(new OracleParameter("username", username));
                MessageBox.Show("role updated!");
                Main.LoadData("select * from users where username = "+ username, dataGridView1);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Can't grant role.\n\nError:" + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }

}