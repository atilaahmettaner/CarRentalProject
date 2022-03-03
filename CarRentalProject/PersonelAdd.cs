using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class PersonelAdd : Form
    {
        public PersonelAdd()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public byte[] ResimYukleme(System.Drawing.Image Resim)
        {


            using (MemoryStream ms = new MemoryStream())
            {
                Resim.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image Resim)
        {


            using (MemoryStream ms = new MemoryStream())
            {
                Resim.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
                                                                                    
            byte[] file_byte = ResimYukleme(pictureBox1.Image);
            System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);

            // Convert System.Drawing.Image to a byte[] 
            byte[] file_byte2 = ImageToByteArray(pictureBox1.Image);
            // Create a System.Data.Linq.Binary - this is what an "image" column is mapped to
            System.Data.Linq.Binary file_binary2 = new System.Data.Linq.Binary(file_byte2);
            string firstName = firstnameTextBox.Text;
            string lastName = lastNameBox1.Text;
            string contact_Number = telephoneTextBox.Text;
            string email = emailTextBox.Text;


            var st = new Personel
            {
                FirstName = firstName,
                LastName = lastName,
                ContactNumber = contact_Number,
                Email = email,
                Image = file_binary2,
               
            };
            db.Personels.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("başarılı");
            loadData();

        }
      
        void loadData()
        {
            var st = from s in db.Personels select s;
            dataGridView1.DataSource = st;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var st1 = (from s in db.Personels where s.PersonelId == Int32.Parse(customerIdBox1.Text) select s).First();
                db.Personels.DeleteOnSubmit(st1);

                db.SubmitChanges();


                MessageBox.Show("customer delete ");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PersonelAdd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png;*.bmp)| *.jpg; *.jpeg; *.png; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                    p.Image = Image.FromFile(open.FileName); //MessageBox. Show(open.FileName);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
    }

