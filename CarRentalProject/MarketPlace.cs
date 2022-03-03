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
    public partial class MarketPlace : Form
    {

        public MarketPlace()
        {
            InitializeComponent();
        }
        public int Satir { get; set; }
        public int Sutun { get; set; }
        DataClasses1DataContext db = new DataClasses1DataContext();
        Resimle resimle = new Resimle();
        List<Profile> TI = new List<Profile>();
        Profile profile = new Profile();
        Personel personel = new Personel();
        private void MarketPlace_Load(object sender, EventArgs e)
        {
            Satir = 0;
            Sutun = 0;
           panel1.Visible=false; 
           
        }
      
        private void T1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();

                       panel1.Visible = true;

            foreach (var deg in db.Personels)

            {
                yerlestir(resimle.ResimGetirme(deg.Image.ToArray()), deg.FirstName, deg.LastName,deg.Email);  
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void yerlestir(Image resim, string isim,string soyisim, string mail)
        {
            Profile user = new Profile();
            
            user.label3.Text = isim;
            user.pictureBox1.Image = resim;
            user.label2.Text = soyisim;
            user.label1.Text = mail;
            
            TI.Add(user);
            user.Dock=DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(user, Satir, Sutun);
            Sutun += 0;
            if (Sutun==1)
            {
                Satir++;
                Sutun = 0;
                
            }
              
            
           
        }
         
     
    }
}
