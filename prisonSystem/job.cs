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
    public partial class job : Form
    {
        private string connectionString = Main.connectionString;

        private void LoadData(string query)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);

                    dataGridView1.DataSource = dtable;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public job()
        {
            InitializeComponent();
        }


        private void guard_Load(object sender, EventArgs e)
        {
            LoadData("Select jnumber,name,salary from job order by jnumber");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO job (jnumber,name,salary) VALUES (:jnumber, :name, :salary)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("jnumber", int.Parse(idTextBox.Text)));
                        command.Parameters.Add(new OracleParameter("name", nameTextBox.Text));
                        command.Parameters.Add(new OracleParameter("salary", decimal.Parse(salaryTextBox.Text)));

                        command.ExecuteNonQuery();
                        LoadData("Select jnumber,name,salary from job order by jnumber");
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

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || idTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the number of the job you want to edit.");
                return;
            }
            else if (nameTextBox.Text == ""|| nameTextBox.Text == " ") {
                MessageBox.Show("Error Has Accured: please enter the new name of the job.");
                return;
            }
            else if (salaryTextBox.Text == "" || salaryTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the new salary of the job");
                return;
            }
            string query = "UPDATE job SET jnumber = "+int.Parse(idTextBox.Text)+", name = :name, salary= :salary";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("name", nameTextBox.Text));
                        command.Parameters.Add(new OracleParameter("salary", decimal.Parse(salaryTextBox.Text)));

                        command.ExecuteNonQuery();
                        LoadData("Select jnumber,name,salary from job order by jnumber");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Has Accured:" + ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || idTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the number of the job you want to DELETE.");
                return;
            }

            string query = "DELETE FROM job WHERE jnumber= :jnumber";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("id", int.Parse(idTextBox.Text)));

                        command.ExecuteNonQuery();
                        LoadData("Select jnumber,name,salary from job order by jnumber");
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
            LoadData("SELECT DISTINCT prisoner.id AS ID, prisoner.fname || ' ' || prisoner.lname AS Name, SUM(job.salary) OVER(PARTITION BY prisoner.id) AS Total_Salary " +
                            "FROM prisoner " +
                            "JOIN prisoner_job ON prisoner.id = prisoner_job.prisoner_id " +
                            "JOIN job ON prisoner_job.job_number = job.jnumber " +
                            "ORDER BY prisoner.id");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadData("Select jnumber,name,salary from job order by jnumber");
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO prisoner_job (prisoner_id,job_number) VALUES (:prisoner_id, :job_number)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("prisoner_id", int.Parse(pidTextBox.Text)));
                        command.Parameters.Add(new OracleParameter("job_number", int.Parse(jidTextBox.Text)));

                        command.ExecuteNonQuery();
                        try {
                            LoadData("SELECT prisoner.id AS ID, prisoner.fname || ' ' || prisoner.lname AS \"Full Name\", job.name AS \"Job Name\", job.salary AS \"Job Salary\" "
                            + "FROM prisoner "
                            + "JOIN prisoner_job ON prisoner.id = prisoner_job.prisoner_id "
                            + "JOIN job ON prisoner_job.job_number = job.jnumber "
                            + "ORDER BY prisoner.id");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error Has Accured in show data:" + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Has Accured:" + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
