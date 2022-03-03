using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class PersonelPage : Form
    {
        public PersonelPage()
        {
            InitializeComponent();
        }
        public void ShowthisForm(object form)
        {

            panel1.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            panel1.Tag = frm;
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            ShowthisForm(new CarAdd());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowthisForm(new MarketPlace());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowthisForm(new ListPage());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowthisForm(new CustomerUpdate());
        }
    }
}
