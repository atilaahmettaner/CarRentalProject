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
    public partial class CarReview : Form
    {
        public CarReview()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        Resimle resimle = new Resimle();
      
        
        List<Profile> TI = new List<Profile>();
        Profile profile = new Profile();
        void ekranaYazdir()
        {
           
        }
        private void CarReview_Load(object sender, EventArgs e)
        {
                
            
        }
        public void yerlestir(Image resim, string firstName, string lastname, string email,string concact )
        {
            Profile cars = new Profile();
               
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9platenumber_Click(object sender, EventArgs e)
        {

        }
    }
}
