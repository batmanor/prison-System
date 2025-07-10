using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisonSystem
{
    public partial class Form2alter : Form
    {
        private string connectionString = Main.connectionString;
        
        public Form2alter()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "";
            if (prisonerRadioButton.Checked)
                query = "SELECT * FROM prisoner ORDER BY id";

            else if(arcPrisRadioButton.Checked)
                query = "SELECT * FROM past_prisoner ORDER BY id";

            else if(arcGuardRadioButton.Checked)
                query = "SELECT * FROM past_guard ORDER BY id";

            else if (cellRadioButton.Checked)
                query = "SELECT cnumber, csize, snumber FROM cell ORDER BY cnumber";

            else if (guardRadioButton.Checked)
                query = "SELECT * FROM guard ORDER BY id";

            else if (jobRadioButton.Checked)
                query = "SELECT * FROM job ORDER BY jnumber";

            else if (pjRadioButton.Checked)
                query = "SELECT prisoner.id AS ID, prisoner.fname || ' ' || prisoner.lname AS Name, job.name AS Job, job.salary AS salary "
                    + "FROM prisoner "
                    + "JOIN prisoner_job ON prisoner.id = prisoner_job.prisoner_id "
                    + "JOIN job ON prisoner_job.job_number = job.jnumber "
                    + "ORDER BY prisoner.id";
            else if (sectionRadioButton.Checked)
                query = "SELECT * FROM section";
            else if (pcRadioButton.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter the cell number.");
                    return;
                }
                query = "SELECT * FROM prisoner WHERE cell_number=" + textBox1.Text;

            }
            else
            {
                MessageBox.Show("Please select a table to view.");
                return; 
            }
            Main.LoadData(query, dataGridView1);
        }

        private void guardRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Close();
        }
    }
}
