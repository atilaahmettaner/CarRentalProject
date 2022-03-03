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
    public partial class CarList : UserControl
    {
        
        public CarList()
        {
            InitializeComponent();
        }
         public static int carid { get; set; }
        public static int carid1 { get; set; }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            carid = Convert.ToInt32(kryptonButton1.Tag);
            
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            carid1 = Convert.ToInt32(kryptonButton2.Tag);
        }

        private void CarList_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
