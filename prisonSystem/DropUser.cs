using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisonSystem
{
    public partial class DropUser : Form
    {
        public DropUser()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Main.LoadData("Select * from users", dataGridView1);
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            string query = "drop user "+ idTextBox.Text.Trim().ToUpper();

            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                bool isDropped = false;
                try
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand(query, connection);
                    command.ExecuteNonQuery();
                    isDropped = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Has Accured 1:" + ex.Message);
                }
                if (isDropped)
                {
                    try
                    {
                        OracleCommand command = new OracleCommand($"delete from users where username = :username", connection);
                        command.Parameters.Add(new OracleParameter("username", idTextBox.Text.ToUpper().Trim()));
                        command.ExecuteNonQuery();
                        Main.LoadData("Select * from users", dataGridView1);
                        Main.commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Has Accured 2:" + ex.Message);
                    }
                }
            }

        }

        private void DropUser_Load(object sender, EventArgs e)
        {
            Main.LoadData("Select * from users", dataGridView1);
        }
    }
}
