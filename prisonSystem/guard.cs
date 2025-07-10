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
    public partial class guard : Form
    {

        private void LoadData(string query)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(Main.connectionString))
                {
                    connection.Open();

                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);

                    dataGridView1.DataSource = dtable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        public guard()
        {
            InitializeComponent();
        }


        private void guard_Load(object sender, EventArgs e)
        {
            LoadData("Select * from guard order by id");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO guard (id, fname, lname, age, salary, snumber) VALUES (guard_seq.NEXTVAL, :fname, :lname, :age, :salary,:section)";

            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {

                        command.Parameters.Add(new OracleParameter("id", idTextBox.Text));
                        command.Parameters.Add(new OracleParameter("fname", fnameTextBox.Text));
                        command.Parameters.Add(new OracleParameter("lname", lnameTextBox.Text));
                        command.Parameters.Add(new OracleParameter("age", int.Parse(ageTextBox.Text)));
                        command.Parameters.Add(new OracleParameter("salary", decimal.Parse(salaryTextBox.Text)));
                        command.Parameters.Add(new OracleParameter("section", decimal.Parse(sectionTextBox.Text)));

                        command.ExecuteNonQuery();
                        LoadData("Select * from guard order by id");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Has Accured:"+ex.Message);
                }
            }

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
            else if (ageTextBox.Text == "" || ageTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the age");
                return;
            }
            else if (salaryTextBox.Text == "" || salaryTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the salary");
                return;
            }
            else if (idTextBox.Text == "" || idTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Occurred: please enter the ID");
                return;
            }


            string query = "UPDATE guard SET fname = :fname, lname = :lname, age = :age, salary= :salary WHERE id = :id";

            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("fname", fnameTextBox.Text));
                        command.Parameters.Add(new OracleParameter("lname", lnameTextBox.Text));
                        command.Parameters.Add(new OracleParameter("age", int.Parse(ageTextBox.Text)));
                        command.Parameters.Add(new OracleParameter("salary", decimal.Parse(salaryTextBox.Text)));
                        command.Parameters.Add(new OracleParameter("id", int.Parse(idTextBox.Text)));

                        command.ExecuteNonQuery();
                        LoadData("Select * from guard order by id");
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
                MessageBox.Show("Error Has Accured: please enter the id");
                return;
            }

            string query = "DELETE FROM guard WHERE id= :id";

            using (OracleConnection connection = new OracleConnection(Main.connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("id", int.Parse(idTextBox.Text)));

                        command.ExecuteNonQuery();
                        LoadData("Select * from guard order by id");
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
            if (idTextBox.Text == "" || idTextBox.Text == " ")
            {
                MessageBox.Show("Error Has Accured: please enter the id");
                return;
            }
            string query = "SELECT * FROM guard WHERE id = "+idTextBox.Text;

            LoadData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.ShowDialog();
            Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.LoadData("SELECT * from section", dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.LoadData("Select * from guard order by id",dataGridView1);
        }
    }
}
