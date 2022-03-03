using System;

using System.Data;

using System.Linq;

using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class ListPage : Form
    {
        CarList carlist = new CarList();

        public ListPage()
        {

            InitializeComponent();

        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        Resimle resimle = new Resimle();
        private void ListPage_Load(object sender, EventArgs e)
        {

            
            panel2.Visible = false;
            panel3.Visible = false;
        }
        public void Baslangic()
        {
                foreach (var deg in db.Cars)
            {
                CarList carlist = new CarList();
                carlist.label3.Text = deg.CarBrand;
                carlist.label2.Text = deg.CarModel;
                carlist.label1.Text = (deg.RentPrice).ToString();
                carlist.label9.Text = deg.Status;
                carlist.kryptonButton1.Tag = deg.CarId;
                carlist.pictureBox1.Image = resimle.ResimGetirme(deg.Image.ToArray());
                carlist.kryptonButton1.Click += T1_Click;
                
                carlist.Dock = DockStyle.Top;
                 
                panel1.Controls.Add(carlist);
                carlist.kryptonButton2.Visible = false;
            }
        }
        private void T1_Click(object sender, EventArgs e)
        {
            CarList carList = new CarList();
            int index = CarList.carid;
            var sor = db.Cars.First(x => x.CarId == index);
            pictureBox1.Image = resimle.ResimGetirme(sor.Image.ToArray());
            markalbl.Text = sor.CarBrand;
            labelmodel.Text = sor.CarModel;
            labelprice.Text = sor.RentPrice.ToString();
            label5status.Text = sor.Status;
            label11description.Text = sor.Description;
            label9platenumber.Text = sor.Plate_number;
            label12color.Text = sor.Color;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void rentbtn_Click(object sender, EventArgs e)
        {
                foreach (var deg in db.Rentals)
                {
                

                    int s = CarList.carid;
                    var sor = db.Cars.First(x => x.CarId == s);
                    int customerId = Convert.ToInt32(textBox1.Text);
                    int carId = CarList.carid;
                    decimal rentPrice = (decimal)sor.RentPrice;
                  
                    DateTime rentalDate = dateTimePicker1.Value;
                    DateTime returnDate = dateTimePicker2.Value;
                    System.TimeSpan span = returnDate.Subtract(rentalDate);
                    int totalDays = Convert.ToInt32(span.TotalDays);
                    decimal a =decimal.Parse(totalDays.ToString()) * rentPrice;
                    sor.Status = "kırada";
                    string status = sor.Status;

                    var st = new Rental
                    {
                        
                        CustomerId = customerId,
                        CarId = carId,
                        RentalDate = rentalDate,
                        ReturnDate = returnDate,
                        Status = status,
                                        
                        RentPrice=a,
                    };
                    db.Rentals.InsertOnSubmit(st);
                    db.SubmitChanges();
                    MessageBox.Show("başarılı");
                break;
                }
           
           
        }
        public void span() {
            var s = new Rental();
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
              

            var car = from cust in db.Cars
                      where cust.Status == comboBox1.Text
                      select cust;       
            foreach  (var a in car)
            {
                CarList carlist = new CarList();
                carlist.label3.Text = a.CarBrand;
                carlist.label2.Text = a.CarModel;
                carlist.label1.Text = (a.RentPrice).ToString();
                carlist.label9.Text = a.Status;
                carlist.kryptonButton2.Tag = a.CarId;
                carlist.pictureBox1.Image = resimle.ResimGetirme(a.Image.ToArray());
                carlist.kryptonButton1.Visible = false;
                if (comboBox1.Text == "kiralanabillir")
                {
                    carlist.kryptonButton2.Visible = false;
                    carlist.kryptonButton1.Visible = true;
                    panel1.Visible = true;
                  
                }
                else if (comboBox1.Text == "kırada")
                {
                    carlist.kryptonButton1.Visible = false;
                    carlist.kryptonButton1.Click += T1_Click;
                }
                carlist.kryptonButton1.Tag = a.CarId;
                carlist.kryptonButton1.Click += T1_Click;
                carlist.kryptonButton2.Click += T2_Click;
                carlist.Dock = DockStyle.Top;
                
                panel1.Controls.Add(carlist);
                
            }
           
        }
        private void T2_Click(object sender, EventArgs e)
        {
            CarList carList = new CarList();
            int index = CarList.carid1;

            var sor = db.Cars.First(x => x.CarId == index);
            var car = db.Rentals.First(x => x.CarId == index);
            var cus = db.Customers.First(x => x.CustomerId == car.CustomerId);
            
            pictureBox2.Image = resimle.ResimGetirme(sor.Image.ToArray());
            markatxt.Text = sor.CarBrand;
            modeltxt.Text = sor.CarModel;
            toplamFiyattxt.Text = car.RentPrice.ToString();
            firstlastnametxt.Text = cus.FirstName;
            contactnumberlbl.Text = cus.Contact_Number;
            adresslbl.Text = cus.address;


            
          double a =Convert.ToDouble(car.RentPrice / sor.RentPrice);
            label7.Text = a.ToString();
            label12.Text = sor.RentPrice.ToString();
            plakalbl.Text = sor.Plate_number;
            
            panel3.Visible = true;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Baslangic();                
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        void a()
        {

            var result = (from p in db.Cars
                          join o in db.Rentals on p.CarId equals o.CarId
                          join c in db.Customers on o.CustomerId equals c.CustomerId
                          select new
                          {

                              p.CarBrand,
                              p.CarModel,
                              o.RentPrice,
                              c.FirstName,
                              c.LastName,
                              o.RentalDate,
                              o.ReturnDate,
                              c.address
                          });
            foreach (var x in result)
            {
            
            }
        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
 
}



                
            
      
