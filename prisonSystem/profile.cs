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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void managePrivs_Load(object sender, EventArgs e)
        {
            Main.LoadData("SELECT username, profile FROM dba_users WHERE username = '"+Main.username+"'", dataGridView1);
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
                string profileOne = "high_Tier";
                string profileTwo = "low_Tier";
                try
                {
                    connection.Open();
                    if (privsRadioButton.Checked)
                    {
                        string query = "ALTER USER "+user+" PROFILE " + profileOne.ToUpper();

                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show(profileOne.ToUpper() + " granted!");
                    }

                    else if (RoleRadioButton.Checked)
                    {
                        string query = "ALTER USER " + user + " PROFILE " + profileTwo.ToUpper();

                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show(profileTwo.ToUpper()+" granted!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("updete failed.\n\nError: " + ex.Message);
                }
            }
        }

        


        private void userButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text.Trim().ToUpper();
            Main.LoadData("SELECT username, profile FROM dba_users WHERE username = '" + user + "'", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.LoadData("SELECT DISTINCT grantee FROM dba_role_privs WHERE granted_role IN ('DBA','PRISON_ADMIN','VIEWER_PRISONER','VIEWER_GUARD','PRISON_HR','CONNECT') order by grantee", dataGridView1);

        }
    }
}
