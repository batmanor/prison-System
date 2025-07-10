using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace prisonSystem
{
    public partial class cell : Form
    {
        private string connectionString = Main.connectionString;

        public cell()
        {
            InitializeComponent();
        }


        private void guard_Load(object sender, EventArgs e)
        {
            try
            {
                Main.LoadData("SELECT cnumber as \"cell number\", csize as \"cell size\", sname as \"section name\" from cell join section on cell.snumber = section.snumber",dataGridView1);
            }catch(Exception ex)
            {
                MessageBox.Show("error has accured:" + ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO cell (cnumber, csize) VALUES (:cnumber, :csize)";
            if(int.Parse(csizeTextBox.Text)>4 || int.Parse(csizeTextBox.Text) < 1)
            {
                MessageBox.Show("Error Has Accured: cell size should be between 1 and 4");
            }
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("cnumber", cnumberTextBox.Text));
                        command.Parameters.Add(new OracleParameter("csize", csizeTextBox.Text));

                        command.ExecuteNonQuery();
                        Main.LoadData("Select * from cell order by cnumber",dataGridView1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Has Accured:"+ex.Message);
                }
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (cnumberTextBox.Text == "" || cnumberTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the cell number");
                return;
            }
            
            string query = "DELETE FROM cell WHERE cnumber= :cnumber";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("cnumber", int.Parse(cnumberTextBox.Text)));

                        command.ExecuteNonQuery();
                        Main.LoadData("Select * from cell order by cnumber",dataGridView1);
                        MessageBox.Show("Remember to send the prisoners to another cells...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Has Accured:" + ex.Message);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (cnumberTextBox.Text == "" || cnumberTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the id");
                return;
            }

            Main.LoadData("SELECT id as prisoner_id, fname|| ' ' || lname as \"full_name\" FROM prisoner WHERE cell_number = "+ cnumberTextBox.Text, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.LoadData("SELECT * from section", dataGridView1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
