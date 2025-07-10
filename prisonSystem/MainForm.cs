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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, {Main.username}.";
        }

        private void presonerBtn_Click(object sender, EventArgs e)
        {
            prisoner p = new prisoner();
            p.ShowDialog();
        }

        private void guardBtn_Click(object sender, EventArgs e)
        {
            guard g = new guard();
            g.ShowDialog();
        }

        private void cellBtn_Click(object sender, EventArgs e)
        {
            cell c = new cell();
            c.ShowDialog();

        }

        private void jobBtn_Click(object sender, EventArgs e)
        {
            job j = new job();
            j.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2alter v = new Form2alter();
            v.ShowDialog();
        }
    }
}
