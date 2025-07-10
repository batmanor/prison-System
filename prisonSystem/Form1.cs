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
using System.Configuration;
using System.Data;

namespace prisonSystem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            string TestConnectionString = $"Data Source={Main.deviceName}/{Main.serviceName};User ID={usernameTextBox.Text.Trim().ToUpper()};Password={passwordTextBox.Text.Trim()};Unicode=True";
            using (OracleConnection connection = new OracleConnection(TestConnectionString))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    Main.username = usernameTextBox.Text.Trim().ToUpper();
                    Main.password = passwordTextBox.Text.Trim();
                    splitForm sf = new splitForm();
                    Hide();
                    sf.Show();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong username or password, please try again.error: "+ex.Message);
                }
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }
    }
}



