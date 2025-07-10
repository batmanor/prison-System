using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prisonSystem
{
    public partial class splitForm : Form
    {
        public splitForm()
        {
            InitializeComponent();
        }

        private void mainFormButton_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.ShowDialog();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateUser c = new CreateUser();
            c.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            managePrivs m = new managePrivs();
            m.ShowDialog();
        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            DropUser d = new DropUser();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.f1.Show();
        }

        private void splitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
