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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataClasses1DataContext context = new DataClasses1DataContext();
        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton1_Click(object sender, EventArgs e)
        {




            if (IsvalidUser(emailTxtbox.Text, textBox2.Text))

            {

                MainPage mainPage = new MainPage();


                mainPage.Show();



            }
            else if (IsvalidCustomer(emailTxtbox.Text, textBox2.Text))
            {
                PersonelPage personelPage = new PersonelPage();


                personelPage.Show();
            }
            else
                MessageBox.Show("giriş bilgilerinizi kontrol ed");

           

        }



        private bool IsvalidUser(string userName, string password)

        {



            

            var q = from p in context.Admins

                    where p.Email == emailTxtbox.Text

                    && p.Password == textBox2.Text

                    select p;



            if (q.Any())

            {

                return true;

            }

            else

            {

                return false;

            }
        }
        private bool IsvalidCustomer(string userName, string password)

        {





            var q = from p in context.Personels

                    where p.Email == emailTxtbox.Text

                    && p.Password == textBox2.Text

                    select p;



            if (q.Any())

            {

                return true;

            }

            else

            {

                return false;

            }
        }

    }
}