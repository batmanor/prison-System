using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace prisonSystem
{
    public partial class managePrivs : Form
    {
        public managePrivs()
        {
            InitializeComponent();
        }

        private void managePrivs_Load(object sender, EventArgs e)
        {
            Main.LoadData("select role from dba_roles where role in ('DBA','PRISON_ADMIN','VIEWER_PRISONER','VIEWER_GUARD','PRISON_HR','CONNECT')", dataGridView1);
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    Main.LoadData("select role from dba_roles where role in ('DBA','PRISON_ADMIN','VIEWER_PRISONER','VIEWER_GUARD','PRISON_HR','CONNECT');", dataGridView1);
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void grantBtn_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                string user = usernameTextBox.Text.Trim().ToUpper();
                string table = TableTextBox.Text.Trim().ToUpper();
                string privilege = PrivsTextBox.Text.Trim().ToUpper();
                try
                {
                    connection.Open();
                    if (privsRadioButton.Checked)
                    {
                        string query = "GRANT "+privilege+" ON "+table+" TO "+user;

                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Privilege granted!");
                    }

                    else if (RoleRadioButton.Checked)
                    {
                        string query = "GRANT "+ privilege + " TO "+user;

                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Role granted!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Grant failed.\n\nError: " + ex.Message);
                }
            }
        }


        private void revokeBtn_Click(object sender, EventArgs e)
        {
            using(OracleConnection connection = new OracleConnection(Main.connectionString))
            {

                connection.Open();
                string privRole = PrivsTextBox.Text.Trim().ToUpper();
                string table = TableTextBox.Text.Trim().ToUpper();
                string user = usernameTextBox.Text.Trim().ToUpper();

                //revoke privs
                if (privsRadioButton.Checked)
                {
                    string query = "revoke " + privRole + " on " + table + " from " + user;
                    try
                    {
                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("privs revoked!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("can't revoke privilege.\n\nError: " + ex);
                    }
                }
                //end revoke privs
                //revoke roles
                else if (RoleRadioButton.Checked)
                {
                    string query = "revoke " + privRole + " from "+ user;
                    try
                    {
                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("roles revoked!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("can't revoke role.\n\nError: " + ex);
                    }
                }
                //end revoke roles
            }//end connection
        }// end revoke btn

        private void RoleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            privRoleLable.Text = "Role:";
            TableLabel.Hide();
            TableLabel.Enabled = false;
            TableTextBox.Hide();
            TableTextBox.Enabled = false;
            Main.LoadData("select role from dba_roles where role in ('DBA','PRISON_ADMIN','VIEWER_PRISONER','VIEWER_GUARD','PRISON_HR','CONNECT')",dataGridView1);
        }

        private void privsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TableLabel.Show();
            TableLabel.Enabled = true;
            TableTextBox.Show();
            TableTextBox.Enabled = true;
            privRoleLable.Text = "Privilege:";
            Main.LoadData("SELECT table_name, privilege FROM (SELECT 'PRISONER' AS table_name FROM dual UNION ALL SELECT 'JOB' FROM dual UNION ALL SELECT 'PRISONER_JOB' FROM dual UNION ALL SELECT 'GUARD' FROM dual  UNION ALL SELECT 'SECTION' FROM dual) t  CROSS JOIN (SELECT 'SELECT' AS privilege FROM dual UNION ALL SELECT 'INSERT' FROM dual  UNION ALL SELECT 'UPDATE' FROM dual UNION ALL SELECT 'DELETE' FROM dual  ) p  ORDER BY table_name, privilege", dataGridView1);
        }



        private void userButton_Click(object sender, EventArgs e)
        {
            Main.LoadData("SELECT DISTINCT grantee FROM dba_role_privs WHERE granted_role IN ('DBA','PRISON_ADMIN','VIEWER_PRISONER','VIEWER_GUARD','PRISON_HR','CONNECT') order by grantee", dataGridView1);
        }



        private void userRoleButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || usernameTextBox.Text == " ")
            {
            label1.Text = "please enter the username:";
            label1.ForeColor = Color.Red;
            return;
            }
            else
            {
                label1.Text = "Username:";
                label1.ForeColor = Color.Black;
                Main.LoadData("SELECT grantee, granted_role, admin_option FROM dba_role_privs WHERE grantee = '" + usernameTextBox.Text.Trim().ToUpper() + "'", dataGridView1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming the user name is in the first column (index 0)
                string selectedUsername = row.Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedUsername))
                {
                    usernameTextBox.Text = selectedUsername.ToUpper(); // Oracle usernames are usually uppercase
                }
            }
        }

        private void userPrivsButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || usernameTextBox.Text == " ")
            {
                label1.Text = "please enter the username:";
                label1.ForeColor = Color.Red;
                return;
            }
            else
            {
                label1.Text = "Username:";
                label1.ForeColor = Color.Black;
                Main.LoadData("SELECT owner, privilege, table_name FROM dba_tab_privs WHERE grantee = '" + usernameTextBox.Text.Trim().ToUpper() + "'", dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.ShowDialog();
        }
    }
}
