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
    public partial class MainMenu : Form
    {
        private Form1 _form1;
        private Profile form2;
        public MainMenu(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            form2 = new Profile(this) { Visible = false };
        }
        public MainMenu()
        {
            InitializeComponent();
            
            form2 = new Profile(this) { Visible = false };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Records h = new Records();
            Close();
            h.Show();
            h.Location = Location;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            History z = new History();
            Close();
            z.Show();
            z.Location = Location;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 j = new Form5();
            Close();
            j.Show();
            j.Location = Location;
        }
    }
}
