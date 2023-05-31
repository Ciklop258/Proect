using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu g = new MainMenu();
            Close();
            g.Show();
            g.Location = Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            Close();
            f.Show();
            f.Location = Location;
        }
    }
}
