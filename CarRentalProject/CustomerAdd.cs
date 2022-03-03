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
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();
        }
        string genders;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            customerIdBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString();
            firstnameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            lastNameBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            telephoneTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Contact_Number"].Value.ToString();
            emailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            genders = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            adressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();


        }
        DataClasses1DataContext db =new  DataClasses1DataContext();
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (telephoneTextBox.Text.Length == 11)
            {
                string firstName = firstnameTextBox.Text;
                string lastName = lastNameBox1.Text;
                string contact_Number = telephoneTextBox.Text;
                string email = emailTextBox.Text;
                string gender = genders;
                string Address = adressTextBox.Text;
                var st = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Contact_Number = contact_Number,
                    Email = email,
                    Gender = gender,
                    address = Address,
                };
                db.Customers.InsertOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("başarılı");
                loadData();

            }
            else
                MessageBox.Show("telefon numaranız 11 haneli olmamlı");
        }
            
         void loadData() {
            var st = from s in db.Customers select s;
            dataGridView1.DataSource = st;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Kadın";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Erkek";
        }
                            
        private void deleteButton_Click(object sender, EventArgs e)
        {

            try {  var st1 = (from s in db.Customers where s.CustomerId == Int32.Parse(customerIdBox1.Text) select s).First();
            db.Customers.DeleteOnSubmit(st1);
            
            db.SubmitChanges();
            
            
            MessageBox.Show("customer delete ");
            loadData();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
        private void CustomerAdd_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string search = searchTextBox1.Text;
           
            var st = from s in db.Customers where s.FirstName.Contains(search) select s;
            dataGridView1.DataSource = st;
        }

        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

