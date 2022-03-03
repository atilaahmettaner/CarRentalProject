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
    public partial class StatisticPage : Form
    {
        public StatisticPage()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void StatisticPage_Load(object sender, EventArgs e)
        {
            label1.Size = new Size(200, 32);
            label1.AutoSize = false;
            int a = db.Customers.Count();
            int b = db.Cars.Count();
            label1.Text = a.ToString();
            
            label2.Text = b.ToString();
            decimal sum1 = db.Rentals.Select(t => t.RentPrice ?? 0).Sum();
            label3.Text = sum1.ToString()+ " ₺";
            int c = db.Rentals.Count();
            label7.Text = c.ToString();
            double yüzde = ((c * 100) / b);
            label9.Text = yüzde.ToString();
            circularProgressBar1.Text = yüzde.ToString();
            circularProgressBar1.Value =Convert.ToInt32( yüzde);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
