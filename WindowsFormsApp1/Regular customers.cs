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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu o = new MainMenu();
            Close();
            o.Show();
            o.Location = Location;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 m = new Form6();
            Close();
            m.Show();
            m.Location = Location;
        }
    }
}
