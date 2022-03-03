
namespace CarRentalProject
{
    partial class CustomerAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAdd));
            this.customerIdBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.lastNameBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.deleteButton = new Krypton.Toolkit.KryptonButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.adressTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.firstnameTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.telephoneTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.emailTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIdBox1
            // 
            this.customerIdBox1.Location = new System.Drawing.Point(223, 26);
            this.customerIdBox1.Name = "customerIdBox1";
            this.customerIdBox1.Size = new System.Drawing.Size(90, 27);
            this.customerIdBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customerIdBox1.StateCommon.Border.Rounding = 5F;
            this.customerIdBox1.TabIndex = 51;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(105, 149);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 49;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(58, 149);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 48;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kadın";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(3, 59);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.kryptonLabel6.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel6.TabIndex = 47;
            this.kryptonLabel6.Values.Text = "Soyisim";
            // 
            // lastNameBox1
            // 
            this.lastNameBox1.Location = new System.Drawing.Point(58, 52);
            this.lastNameBox1.Name = "lastNameBox1";
            this.lastNameBox1.Size = new System.Drawing.Size(90, 27);
            this.lastNameBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastNameBox1.StateCommon.Border.Rounding = 5F;
            this.lastNameBox1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.deleteButton.Location = new System.Drawing.Point(80, 241);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(78, 55);
            this.deleteButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.StateCommon.Border.Rounding = 20F;
            this.deleteButton.TabIndex = 45;
            this.deleteButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Values.Image")));
            this.deleteButton.Values.Text = "sil";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(539, 202);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 89);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            this.kryptonLabel5.Size = new System.Drawing.Size(33, 20);
            this.kryptonLabel5.TabIndex = 43;
            this.kryptonLabel5.Values.Text = "mail";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(58, 172);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(90, 27);
            this.adressTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.adressTextBox.StateCommon.Border.Rounding = 5F;
            this.adressTextBox.TabIndex = 4;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(58, 19);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(90, 27);
            this.firstnameTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstnameTextBox.StateCommon.Border.Rounding = 5F;
            this.firstnameTextBox.TabIndex = 0;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 115);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel4.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel4.TabIndex = 40;
            this.kryptonLabel4.Values.Text = "telefon";
            this.kryptonLabel4.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 179);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueLightMode;
            this.kryptonLabel3.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel3.TabIndex = 39;
            this.kryptonLabel3.Values.Text = "adres";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Cursor = System.Windows.Forms.Cursors.No;
            this.kryptonLabel2.Location = new System.Drawing.Point(20, 26);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel2.Size = new System.Drawing.Size(32, 20);
            this.kryptonLabel2.TabIndex = 38;
            this.kryptonLabel2.Values.Text = "isim";
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(58, 115);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(90, 27);
            this.telephoneTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.telephoneTextBox.StateCommon.Border.Rounding = 5F;
            this.telephoneTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(58, 86);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(90, 27);
            this.emailTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.emailTextBox.StateCommon.Border.Rounding = 5F;
            this.emailTextBox.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnAdd.Location = new System.Drawing.Point(-4, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 55);
            this.btnAdd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 20F;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Values.Image")));
            this.btnAdd.Values.Text = "ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "search";
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.Location = new System.Drawing.Point(223, 82);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Size = new System.Drawing.Size(90, 27);
            this.searchTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchTextBox1.StateCommon.Border.Rounding = 5F;
            this.searchTextBox1.TabIndex = 54;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.kryptonButton1.Location = new System.Drawing.Point(319, 76);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(67, 48);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20F;
            this.kryptonButton1.TabIndex = 55;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "ara";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 149);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 20);
            this.kryptonLabel1.TabIndex = 56;
            this.kryptonLabel1.Values.Text = "Cinsiyet";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.searchTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerIdBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.lastNameBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerAdd";
            this.Text = "CustomerAdd";
            this.Load += new System.EventHandler(this.CustomerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox customerIdBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox lastNameBox1;
        private Krypton.Toolkit.KryptonButton deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox adressTextBox;
        private Krypton.Toolkit.KryptonTextBox firstnameTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox telephoneTextBox;
        private Krypton.Toolkit.KryptonTextBox emailTextBox;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox searchTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}