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
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
        }
        string genders;
        private void CustomerUpdate_Load(object sender, EventArgs e)
        {

        }
        DataClasses1DataContext db = new DataClasses1DataContext();

      

        private void updateButton_Click(object sender, EventArgs e)
        {
            var st = (from s in db.Customers where s.CustomerId == Int32.Parse(CostumerIdBox.Text) select s).First();
            string firstName = firstnameTextBox.Text;
            string lastName = lastNameBox1.Text;
            string contact_Number = numberTextBox3.Text;
            string email = mailTextBox4.Text;
            string gender = genders;
            string Address = addressTextBox2.Text;
            st.FirstName = firstName;
            st.LastName = lastName;
            st.Contact_Number = contact_Number;
            st.Email = email;
            st.Gender = gender;
            st.address = Address;

            
            db.SubmitChanges();
            MessageBox.Show("başarılı");
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
             genders = "Kadın";
 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Erkek";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var st = (from s in db.Customers where s.CustomerId == Int32.Parse(IdBox1.Text) select s);
            kryptonDataGridView1.DataSource=st;
        }

        private void kryptonLabel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cinsiyet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
