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
    public partial class CarAdd : Form
    {
        public CarAdd()
        {
            InitializeComponent();
        }

        private void CarAdd_Load(object sender, EventArgs e)
        {
            
                string[] arabaArray = { "opel", "fiat", "volvo", "toyota", "Audi", "Renault" };
            comboBox1.Items.AddRange(arabaArray);
        }
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
        void loadData()
        {
            var st = from s in db.Cars select s;
            kryptonDataGridView1.DataSource = st;
        }


        DataClasses1DataContext db = new DataClasses1DataContext();
        private void CarAddButton1_Click(object sender, EventArgs e)
        {
            try
            {
               byte[] file_byte = ResimYukleme(pictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);

                // Convert System.Drawing.Image to a byte[]
                byte[] file_byte2 = ImageToByteArray(pictureBox1.Image);
                // Create a System.Data.Linq.Binary - this is what an "image" column is mapped to
                System.Data.Linq.Binary file_binary2 = new System.Data.Linq.Binary(file_byte2);
                string carBrand = comboBox1.Text;
                string carModel = comboBox2.Text;
                string description = aciklamaTextBox2.Text;
                string plateNumber = plakaTextBox1.Text;
                string color = colorcomboBox3.Text;
                decimal rentPrice = decimal.Parse(rentPriceTextBox1.Text);
                string plate_number = plakaTextBox1.Text;
                DateTime inspectionDate = dateTimePicker1.Value;
                string status = statuscomboBox3.Text;


                var st = new Car
                {
                    CarBrand = carBrand,
                    CarModel = carModel,
                    Description = description,
                    Plate_number = plateNumber,
                    Color = color,
                    RentPrice = rentPrice,
                    Image = file_binary2,
                    Status = status,
                    InspectionDate = inspectionDate,                  
                };
            db.Cars.InsertOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("başarılı");
                loadData(); }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "opel")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Corsa");
                comboBox2.Items.Add("Astra");
                comboBox2.Items.Add("Insignia");
            }
            else if (comboBox1.Text == "fiat")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Egea");
                comboBox2.Items.Add("Doblo ");
                comboBox2.Items.Add("Fiorino");
            }
            else if (comboBox1.Text == "volvo")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("S90");
                comboBox2.Items.Add("XC90 ");
                comboBox2.Items.Add("V40");
            }
            else if (comboBox1.Text == "toyota")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Corolla");
                comboBox2.Items.Add("Yaris ");
                comboBox2.Items.Add("Hilux");
            }
            else if (comboBox1.Text == "Audi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A5");
                comboBox2.Items.Add("Q7");
                comboBox2.Items.Add("RS7");
            }
            else if (comboBox1.Text == "Renault")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("KADJAR");
                comboBox2.Items.Add("MEGANE");
                comboBox2.Items.Add("CLIO");
            }
        }

        private void MarketplaceButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarketPlace market = new MarketPlace();
            market.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var st1 = (from s in db.Cars where s.CarId == Int32.Parse(CarIdtextBox1.Text) select s).First();
                db.Cars.DeleteOnSubmit(st1);

                db.SubmitChanges();


                MessageBox.Show("customer delete ");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarIdtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

            a();
           
        }  
        public void a()
        {
            var car = from cust in db.Cars
                      where cust.Status == comboBox3.Text
                      select cust;
            kryptonDataGridView1.DataSource = car;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var st = (from s in db.Cars where s.CarId == Int32.Parse(CarIdtextBox1.Text) select s).First();
                string carBrand = comboBox1.Text;
                string carModel = comboBox2.Text;
                string plateNumber = plakaTextBox1.Text;
                string status = statuscomboBox3.Text;
                string color = colorcomboBox3.Text;
                string  description = aciklamaTextBox2.Text;
                decimal rentPrice = decimal.Parse(rentPriceTextBox1.Text);
                Image image = pictureBox1.Image;
                st.CarBrand = carBrand;
                st.Plate_number = plateNumber;
                st.Status = status;
                st.CarModel = carModel;
                st.RentPrice = rentPrice;
                st.Description = description;
                byte[] file_byte = ResimYukleme(pictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                byte[] file_byte2 = ImageToByteArray(pictureBox1.Image);
                System.Data.Linq.Binary file_binary2 = new System.Data.Linq.Binary(file_byte2);
                db.SubmitChanges();
                MessageBox.Show("başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex +"! ");
            }
          
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Resimle resimle = new Resimle();
            kryptonDataGridView1.CurrentRow.Selected = true;
            comboBox1.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["CarBrand"].Value.ToString();
            CarIdtextBox1.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["CarId"].Value.ToString();
            comboBox2.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["CarModel"].Value.ToString();
            plakaTextBox1.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["Plate_number"].Value.ToString();
            colorcomboBox3.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            aciklamaTextBox2.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            statuscomboBox3.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            rentPriceTextBox1.Text = kryptonDataGridView1.Rows[e.RowIndex].Cells["RentPrice"].Value.ToString();
            
            int id = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["CarId"].FormattedValue);
            var car = from d in db.Cars
                      where d.CarId == id
                      select d;
            foreach (var item in car)
            {
                pictureBox1.Image = resimle.ResimGetirme(item.Image.ToArray());
                dateTimePicker1.Value =  item.InspectionDate.Value;
            }
           
        }
    }
}
