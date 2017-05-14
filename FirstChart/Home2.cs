using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstChart
{
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }
        public Home2(string lieu,string date )
        {
            InitializeComponent();
            labelLieu.Text = lieu;
            labelDate.Text = date;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Courbe1Form c = new Courbe1Form();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataForm d = new DataForm();
            d.Show();
        }

        private void Home2_Load(object sender, EventArgs e)
        {

        }
    }
}
