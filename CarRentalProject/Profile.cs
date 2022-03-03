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
    public partial class Profile : UserControl
    {
        public static int PersonelId1 { get; set; }
      

        public Profile()
        {
            InitializeComponent();
        }


          
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            PersonelId1  =Convert.ToInt32( kryptonButton1.Tag);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
