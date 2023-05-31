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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 n = new Form5();
            Close();
            n.Show();
            n.Location = Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 b = new Form5();
            Close();
            b.Show();
            b.Location = Location;
        }
    }
}
