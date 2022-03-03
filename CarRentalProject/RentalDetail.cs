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
    public partial class RentalDetail : Form
    {
        public RentalDetail()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
        
        }
        public void b()
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
            kryptonDataGridView1.DataSource = result;

        } 
      

        private void RentDetailbtn_Click(object sender, EventArgs e)
        {
            b();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Copy_Load(object sender, EventArgs e)
        {
                                                                               
        }
    }
}
