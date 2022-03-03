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
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void MainPanel_Load(object sender, EventArgs e)
        {
            decimal sum1 = db.Rentals.Select(t => t.RentPrice ?? 0).Sum();
            int b = db.Cars.Count();
            int c = db.Rentals.Count();


            label3.Text = sum1.ToString();
            double a = ((c * 100) / b);
            circularProgressBar1.Value = Convert.ToInt32(a);
            circularProgressBar1.Text = a.ToString();

        }
    }
}
