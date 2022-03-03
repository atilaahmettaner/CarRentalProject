﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalProject
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	using System.Configuration;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CarRentDb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		public static string sqlconnection = ConfigurationManager.ConnectionStrings["CarRentalProject.Properties.Settings.CarRentDbConnectionString"].ConnectionString;
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    partial void InsertRental(Rental instance);
    partial void UpdateRental(Rental instance);
    partial void DeleteRental(Rental instance);
    partial void InsertPersonel(Personel instance);
    partial void UpdatePersonel(Personel instance);
    partial void DeletePersonel(Personel instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::CarRentalProject.Properties.Settings.Default.CarRentDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Car> Cars
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
		
		public System.Data.Linq.Table<Rental> Rentals
		{
			get
			{
				return this.GetTable<Rental>();
			}
		}
		
		public System.Data.Linq.Table<Personel> Personels
		{
			get
			{
				return this.GetTable<Personel>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminId;
		
		private string _Email;
		
		private string _Password;
		
		private string _FirstName;
		
		private string _LastName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIdChanging(int value);
    partial void OnAdminIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdminId
		{
			get
			{
				return this._AdminId;
			}
			set
			{
				if ((this._AdminId != value))
				{
					this.OnAdminIdChanging(value);
					this.SendPropertyChanging();
					this._AdminId = value;
					this.SendPropertyChanged("AdminId");
					this.OnAdminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Contact_Number;
		
		private string _Email;
		
		private string _Gender;
		
		private string _address;
		
		private EntitySet<Rental> _Rentals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnContact_NumberChanging(string value);
    partial void OnContact_NumberChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    #endregion
		
		public Customer()
		{
			this._Rentals = new EntitySet<Rental>(new Action<Rental>(this.attach_Rentals), new Action<Rental>(this.detach_Rentals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact_Number", DbType="NVarChar(50)")]
		public string Contact_Number
		{
			get
			{
				return this._Contact_Number;
			}
			set
			{
				if ((this._Contact_Number != value))
				{
					this.OnContact_NumberChanging(value);
					this.SendPropertyChanging();
					this._Contact_Number = value;
					this.SendPropertyChanged("Contact_Number");
					this.OnContact_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Rental", Storage="_Rentals", ThisKey="CustomerId", OtherKey="CustomerId")]
		public EntitySet<Rental> Rentals
		{
			get
			{
				return this._Rentals;
			}
			set
			{
				this._Rentals.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Rentals(Rental entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Rentals(Rental entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Car")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CarId;
		
		private string _CarBrand;
		
		private string _Description;
		
		private string _Plate_number;
		
		private string _Status;
		
		private string _Color;
		
		private string _CarModel;
		
		private System.Nullable<decimal> _RentPrice;
		
		private System.Data.Linq.Binary _Image;
		
		private System.Nullable<System.DateTime> _InspectionDate;
		
		private EntitySet<Rental> _Rentals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCarIdChanging(int value);
    partial void OnCarIdChanged();
    partial void OnCarBrandChanging(string value);
    partial void OnCarBrandChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPlate_numberChanging(string value);
    partial void OnPlate_numberChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnCarModelChanging(string value);
    partial void OnCarModelChanged();
    partial void OnRentPriceChanging(System.Nullable<decimal> value);
    partial void OnRentPriceChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    partial void OnInspectionDateChanging(System.Nullable<System.DateTime> value);
    partial void OnInspectionDateChanged();
    #endregion
		
		public Car()
		{
			this._Rentals = new EntitySet<Rental>(new Action<Rental>(this.attach_Rentals), new Action<Rental>(this.detach_Rentals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CarId
		{
			get
			{
				return this._CarId;
			}
			set
			{
				if ((this._CarId != value))
				{
					this.OnCarIdChanging(value);
					this.SendPropertyChanging();
					this._CarId = value;
					this.SendPropertyChanged("CarId");
					this.OnCarIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarBrand", DbType="NVarChar(50)")]
		public string CarBrand
		{
			get
			{
				return this._CarBrand;
			}
			set
			{
				if ((this._CarBrand != value))
				{
					this.OnCarBrandChanging(value);
					this.SendPropertyChanging();
					this._CarBrand = value;
					this.SendPropertyChanged("CarBrand");
					this.OnCarBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plate_number", DbType="NVarChar(50)")]
		public string Plate_number
		{
			get
			{
				return this._Plate_number;
			}
			set
			{
				if ((this._Plate_number != value))
				{
					this.OnPlate_numberChanging(value);
					this.SendPropertyChanging();
					this._Plate_number = value;
					this.SendPropertyChanged("Plate_number");
					this.OnPlate_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(50)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarModel", DbType="NVarChar(50)")]
		public string CarModel
		{
			get
			{
				return this._CarModel;
			}
			set
			{
				if ((this._CarModel != value))
				{
					this.OnCarModelChanging(value);
					this.SendPropertyChanging();
					this._CarModel = value;
					this.SendPropertyChanged("CarModel");
					this.OnCarModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentPrice", DbType="Decimal(7,2)")]
		public System.Nullable<decimal> RentPrice
		{
			get
			{
				return this._RentPrice;
			}
			set
			{
				if ((this._RentPrice != value))
				{
					this.OnRentPriceChanging(value);
					this.SendPropertyChanging();
					this._RentPrice = value;
					this.SendPropertyChanged("RentPrice");
					this.OnRentPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InspectionDate", DbType="Date")]
		public System.Nullable<System.DateTime> InspectionDate
		{
			get
			{
				return this._InspectionDate;
			}
			set
			{
				if ((this._InspectionDate != value))
				{
					this.OnInspectionDateChanging(value);
					this.SendPropertyChanging();
					this._InspectionDate = value;
					this.SendPropertyChanged("InspectionDate");
					this.OnInspectionDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Rental", Storage="_Rentals", ThisKey="CarId", OtherKey="CarId")]
		public EntitySet<Rental> Rentals
		{
			get
			{
				return this._Rentals;
			}
			set
			{
				this._Rentals.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Rentals(Rental entity)
		{
			this.SendPropertyChanging();
			entity.Car = this;
		}
		
		private void detach_Rentals(Rental entity)
		{
			this.SendPropertyChanging();
			entity.Car = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rental")]
	public partial class Rental : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RentalId;
		
		private System.Nullable<System.DateTime> _RentalDate;
		
		private System.Nullable<System.DateTime> _ReturnDate;
		
		private System.Nullable<int> _CarId;
		
		private System.Nullable<int> _CustomerId;
		
		private string _Status;
		
		private System.Nullable<decimal> _RentPrice;
		
		private EntityRef<Car> _Car;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRentalIdChanging(int value);
    partial void OnRentalIdChanged();
    partial void OnRentalDateChanging(System.Nullable<System.DateTime> value);
    partial void OnRentalDateChanged();
    partial void OnReturnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnReturnDateChanged();
    partial void OnCarIdChanging(System.Nullable<int> value);
    partial void OnCarIdChanged();
    partial void OnCustomerIdChanging(System.Nullable<int> value);
    partial void OnCustomerIdChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnRentPriceChanging(System.Nullable<decimal> value);
    partial void OnRentPriceChanged();
    #endregion
		
		public Rental()
		{
			this._Car = default(EntityRef<Car>);
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentalId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RentalId
		{
			get
			{
				return this._RentalId;
			}
			set
			{
				if ((this._RentalId != value))
				{
					this.OnRentalIdChanging(value);
					this.SendPropertyChanging();
					this._RentalId = value;
					this.SendPropertyChanged("RentalId");
					this.OnRentalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentalDate", DbType="Date")]
		public System.Nullable<System.DateTime> RentalDate
		{
			get
			{
				return this._RentalDate;
			}
			set
			{
				if ((this._RentalDate != value))
				{
					this.OnRentalDateChanging(value);
					this.SendPropertyChanging();
					this._RentalDate = value;
					this.SendPropertyChanged("RentalDate");
					this.OnRentalDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="Date")]
		public System.Nullable<System.DateTime> ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this.OnReturnDateChanging(value);
					this.SendPropertyChanging();
					this._ReturnDate = value;
					this.SendPropertyChanged("ReturnDate");
					this.OnReturnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarId", DbType="Int")]
		public System.Nullable<int> CarId
		{
			get
			{
				return this._CarId;
			}
			set
			{
				if ((this._CarId != value))
				{
					if (this._Car.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCarIdChanging(value);
					this.SendPropertyChanging();
					this._CarId = value;
					this.SendPropertyChanged("CarId");
					this.OnCarIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Int")]
		public System.Nullable<int> CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentPrice", DbType="Decimal(7,2)")]
		public System.Nullable<decimal> RentPrice
		{
			get
			{
				return this._RentPrice;
			}
			set
			{
				if ((this._RentPrice != value))
				{
					this.OnRentPriceChanging(value);
					this.SendPropertyChanging();
					this._RentPrice = value;
					this.SendPropertyChanged("RentPrice");
					this.OnRentPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Rental", Storage="_Car", ThisKey="CarId", OtherKey="CarId", IsForeignKey=true)]
		public Car Car
		{
			get
			{
				return this._Car.Entity;
			}
			set
			{
				Car previousValue = this._Car.Entity;
				if (((previousValue != value) 
							|| (this._Car.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Car.Entity = null;
						previousValue.Rentals.Remove(this);
					}
					this._Car.Entity = value;
					if ((value != null))
					{
						value.Rentals.Add(this);
						this._CarId = value.CarId;
					}
					else
					{
						this._CarId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Car");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Rental", Storage="_Customer", ThisKey="CustomerId", OtherKey="CustomerId", IsForeignKey=true, DeleteRule="CASCADE")]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Rentals.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Rentals.Add(this);
						this._CustomerId = value.CustomerId;
					}
					else
					{
						this._CustomerId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Personel")]
	public partial class Personel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonelId;
		
		private string _Email;
		
		private string _Password;
		
		private string _FirstName;
		
		private string _ContactNumber;
		
		private System.Data.Linq.Binary _Image;
		
		private string _LastName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonelIdChanging(int value);
    partial void OnPersonelIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnContactNumberChanging(string value);
    partial void OnContactNumberChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Personel()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonelId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PersonelId
		{
			get
			{
				return this._PersonelId;
			}
			set
			{
				if ((this._PersonelId != value))
				{
					this.OnPersonelIdChanging(value);
					this.SendPropertyChanging();
					this._PersonelId = value;
					this.SendPropertyChanged("PersonelId");
					this.OnPersonelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNumber", DbType="NVarChar(50)")]
		public string ContactNumber
		{
			get
			{
				return this._ContactNumber;
			}
			set
			{
				if ((this._ContactNumber != value))
				{
					this.OnContactNumberChanging(value);
					this.SendPropertyChanging();
					this._ContactNumber = value;
					this.SendPropertyChanged("ContactNumber");
					this.OnContactNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591