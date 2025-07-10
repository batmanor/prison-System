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
    public partial class prisoner : Form
    {
        private string connectionString = Main.connectionString;
        OracleDataReader dr;

        private void LoadData(string query)
        {
            try
            {
                using (OracleConnection cn = new OracleConnection(Main.connectionString))
                {
                    cn.Open();

                    OracleDataAdapter adapter = new OracleDataAdapter(query, cn);
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
        public prisoner()
        {
            InitializeComponent();
        }


        private void guard_Load(object sender, EventArgs e)
        {
            LoadData("Select * from prisoner order by id");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                connection.Open();
                int cellNumber = int.Parse(cellTextBox.Text);
                int count;
                string cellSize= "";
                using(OracleCommand com = new OracleCommand("SELECT csize from cell where cnumber ="+cellNumber, connection))
                {
                    dr = com.ExecuteReader();
                    dr.Read();
                    cellSize = dr["csize"].ToString();

                }
                using(OracleCommand com2 = new OracleCommand("select count (*) from prisoner where cell_number =" + cellNumber, connection))
                {
                    count = Convert.ToInt32(com2.ExecuteScalar());
                }
                if (int.Parse(cellSize)>count)
                {


                    try
                    {
                        using (OracleCommand command = new OracleCommand("INSERT INTO prisoner (id, fname, lname, cell_number) VALUES (prisoner_seq.NEXTVAL, :fname, :lname, :cell_number)", connection))
                        {
                            command.Parameters.Add(new OracleParameter("fname", fnameTextBox.Text));
                            command.Parameters.Add(new OracleParameter("lname", lnameTextBox.Text));
                            command.Parameters.Add(new OracleParameter("cell_number", int.Parse(cellTextBox.Text)));
                            command.ExecuteNonQuery();
                            LoadData("Select * from prisoner order by id");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Has Accured:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("the cell is full, please choose another cell.");
                }
            }            
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from job order by jnumber";
            LoadData(query);
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            if (fnameTextBox.Text == ""|| fnameTextBox.Text == " ") {
                MessageBox.Show("Error Has Accured: please enter the first name");
                return;
            } else if (lnameTextBox.Text == "" || lnameTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the last name");
                return;
            }
            else if (cellTextBox.Text == "" || cellTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the cell number");
                return;
            }

            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                connection.Open();
                int cellNumber = int.Parse(cellTextBox.Text);
                int count;
                string cellSize = "";
                using (OracleCommand com = new OracleCommand("SELECT csize from cell where cnumber =" + cellNumber, connection))
                {
                    dr = com.ExecuteReader();
                    dr.Read();
                    cellSize = dr["csize"].ToString();

                }
                using (OracleCommand com2 = new OracleCommand("select count (*) from prisoner where cell_number =" + cellNumber, connection))
                {
                    count = Convert.ToInt32(com2.ExecuteScalar());
                }
                if (int.Parse(cellSize) > count)
                {


                    try
                    {
                        using (OracleCommand command = new OracleCommand("UPDATE prisoner SET fname = :fname , lname = :lname, cell_number = :cell_number where id = :id", connection))
                        {
                            command.Parameters.Add(new OracleParameter("id", idTextBox.Text));
                            command.Parameters.Add(new OracleParameter("fname", fnameTextBox.Text));
                            command.Parameters.Add(new OracleParameter("lname", lnameTextBox.Text));
                            command.Parameters.Add(new OracleParameter("cell_number", int.Parse(cellTextBox.Text)));

                            command.ExecuteNonQuery();
                            LoadData("Select * from prisoner order by id");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Has Accured:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("the cell is full, please choose another cell.");
                }

            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || idTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the id");
                return;
            }

            string query = "DELETE FROM prisoner WHERE id="+ idTextBox.Text;

            LoadData(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || idTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the id");
                return;
            }
            string query = "SELECT * FROM prisoner WHERE id = " + idTextBox.Text;

            LoadData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData("SELECT prisoner.id AS ID, prisoner.fname || ' ' || prisoner.lname AS \"Full Name\", job.name AS Job, job.salary AS Salary, SUM(job.salary) OVER(PARTITION BY prisoner.id) AS \"Total Salary\" " +
                "FROM prisoner " +
                "JOIN prisoner_job ON prisoner.id = prisoner_job.prisoner_id " +
                "JOIN job ON prisoner_job.job_number = job.jnumber " +
                " ORDER BY prisoner.id ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData("select * from prisoner order by id");
        }
    }
}
