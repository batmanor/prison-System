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
    public partial class CreateUser : Form
    {
       
        public CreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(Main.connectionString))
                {
                    try
                    {
                        connection.Open();
                        OracleCommand command = new OracleCommand("create user " + textBox1.Text.ToUpper().Trim() + " identified by " + textBox2.Text.Trim(), connection);
                        command.ExecuteNonQuery();

                        command.CommandText = "insert into users(username, role) values(:username, :role)";
                        command.Parameters.Add(new OracleParameter("username", textBox1.Text.ToUpper()));
                        if (prisonerRadioButton.Checked)
                            command.Parameters.Add(new OracleParameter("role", "viewer_prisoner"));
                        else if (adminRadioButton.Checked)
                            command.Parameters.Add(new OracleParameter("role", "prison_admin"));
                        else if (guardRadioButton.Checked)
                            command.Parameters.Add(new OracleParameter("role", "viewer_guard"));
                        else if (jobRadioButton.Checked)
                            command.Parameters.Add(new OracleParameter("role", "prison_HR"));
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Has Accured: " + ex.Message + ".\n---couldn't create the user---");
                    }
                }

                string query = "";
                if (prisonerRadioButton.Checked)
                    query = $"grant viewer_prisoner to {textBox1.Text.ToUpper().Trim()}";
                else if (adminRadioButton.Checked)
                    query = $"grant prison_admin to {textBox1.Text.ToUpper().Trim()}";
                else if (guardRadioButton.Checked)
                    query = $"grant viewer_guard to {textBox1.Text.ToUpper().Trim()}";
                else if (jobRadioButton.Checked){
                    query = $"grant prison_HR to {textBox1.Text.ToUpper().Trim()}";
                }
                using (OracleConnection connection = new OracleConnection(Main.connectionString))
                {
                    connection.Open();
                    try
                    {
                        OracleCommand command = new OracleCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Done!");
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Has Accured:" + ex.Message + $".\n---couldn't give role to user: {textBox1.Text.ToUpper()}---");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has Accured:" + ex.Message);
            }
            
        }
    }
}
