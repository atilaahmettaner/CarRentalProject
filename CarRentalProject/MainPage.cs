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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        bool sidebarExpand = false;
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void MainPage_Load(object sender, EventArgs e)
        {
            decimal sum1 = db.Rentals.Select(t => t.RentPrice ?? 0).Sum();
            int b = db.Cars.Count();
            int c = db.Rentals.Count();


            label3.Text = sum1.ToString();
            double a= ((c * 100) / b);
            circularProgressBar1.Value = Convert.ToInt32(a);
            circularProgressBar1.Text = a.ToString();
                }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ShowthisForm(new MarketPlace());
        }
        public void ShowthisForm(object form)
        {

            panel1.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            panel1.Tag = frm;
            frm.Show();       

        }

        private void addcostumerButton2_Click(object sender, EventArgs e)
        {
            ShowthisForm(new CustomerAdd());
        }

        private void mainPageButton_Click(object sender, EventArgs e)
        {
            ShowthisForm(new MainMenu());
        }

        private void listCostumerButton1_Click(object sender, EventArgs e)
        {

        }

        private void rentacarButton_Click(object sender, EventArgs e)
        {
            ShowthisForm(new CarAdd());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowthisForm(new MainPanel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowthisForm(new CustomerAdd());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

      

        private void flowmenupanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                //if sidebar is expand, minimize
                sidebar.Width -= 88;
            if (sidebar.Width == sidebar.MinimumSize.Width )
                {
                    sidebarExpand = false;
                sidebartimer.Stop();
                }
               
            }
             
        else
            {
                sidebar.Width += 88;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }

                sidebarExpand =true;
                sidebartimer.Stop();
            }
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            ShowthisForm(new MarketPlace());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ShowthisForm(new CarAdd());
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowthisForm(new ListPage());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowthisForm(new RentalDetail());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowthisForm(new PersonelAdd());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowthisForm(new StatisticPage());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
            
        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
