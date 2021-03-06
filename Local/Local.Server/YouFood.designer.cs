﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Local.Server
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="YouFoodAdmin")]
	public partial class YouFoodDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertArticle(Article instance);
    partial void UpdateArticle(Article instance);
    partial void DeleteArticle(Article instance);
    partial void InsertArticle_Type(Article_Type instance);
    partial void UpdateArticle_Type(Article_Type instance);
    partial void DeleteArticle_Type(Article_Type instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertRef_Order_Article(Ref_Order_Article instance);
    partial void UpdateRef_Order_Article(Ref_Order_Article instance);
    partial void DeleteRef_Order_Article(Ref_Order_Article instance);
    partial void InsertRestaurant(Restaurant instance);
    partial void UpdateRestaurant(Restaurant instance);
    partial void DeleteRestaurant(Restaurant instance);
    partial void InsertDatabase_Changes(Database_Changes instance);
    partial void UpdateDatabase_Changes(Database_Changes instance);
    partial void DeleteDatabase_Changes(Database_Changes instance);
    #endregion
		
		public YouFoodDataContext() : 
				base(global::Local.Server.Properties.Settings.Default.YouFoodAdminConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public YouFoodDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public YouFoodDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public YouFoodDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public YouFoodDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Article> Article
		{
			get
			{
				return this.GetTable<Article>();
			}
		}
		
		public System.Data.Linq.Table<Article_Type> Article_Type
		{
			get
			{
				return this.GetTable<Article_Type>();
			}
		}
		
		public System.Data.Linq.Table<Order> Order
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Ref_Order_Article> Ref_Order_Article
		{
			get
			{
				return this.GetTable<Ref_Order_Article>();
			}
		}
		
		public System.Data.Linq.Table<Restaurant> Restaurant
		{
			get
			{
				return this.GetTable<Restaurant>();
			}
		}
		
		public System.Data.Linq.Table<Database_Changes> Database_Changes
		{
			get
			{
				return this.GetTable<Database_Changes>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Article")]
	public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Description;
		
		private double _Price;
		
		private int _Id_Article_Type;
		
		private EntitySet<Ref_Order_Article> _Ref_Order_Article;
		
		private EntityRef<Article_Type> _Article_Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    partial void OnId_Article_TypeChanging(int value);
    partial void OnId_Article_TypeChanged();
    #endregion
		
		public Article()
		{
			this._Ref_Order_Article = new EntitySet<Ref_Order_Article>(new Action<Ref_Order_Article>(this.attach_Ref_Order_Article), new Action<Ref_Order_Article>(this.detach_Ref_Order_Article));
			this._Article_Type = default(EntityRef<Article_Type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Article_Type", DbType="Int NOT NULL")]
		public int Id_Article_Type
		{
			get
			{
				return this._Id_Article_Type;
			}
			set
			{
				if ((this._Id_Article_Type != value))
				{
					if (this._Article_Type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_Article_TypeChanging(value);
					this.SendPropertyChanging();
					this._Id_Article_Type = value;
					this.SendPropertyChanged("Id_Article_Type");
					this.OnId_Article_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Ref_Order_Article", Storage="_Ref_Order_Article", ThisKey="Id", OtherKey="Id_Article")]
		public EntitySet<Ref_Order_Article> Ref_Order_Article
		{
			get
			{
				return this._Ref_Order_Article;
			}
			set
			{
				this._Ref_Order_Article.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Type_Article", Storage="_Article_Type", ThisKey="Id_Article_Type", OtherKey="Id", IsForeignKey=true)]
		public Article_Type Article_Type
		{
			get
			{
				return this._Article_Type.Entity;
			}
			set
			{
				Article_Type previousValue = this._Article_Type.Entity;
				if (((previousValue != value) 
							|| (this._Article_Type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Article_Type.Entity = null;
						previousValue.Article.Remove(this);
					}
					this._Article_Type.Entity = value;
					if ((value != null))
					{
						value.Article.Add(this);
						this._Id_Article_Type = value.Id;
					}
					else
					{
						this._Id_Article_Type = default(int);
					}
					this.SendPropertyChanged("Article_Type");
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
		
		private void attach_Ref_Order_Article(Ref_Order_Article entity)
		{
			this.SendPropertyChanging();
			entity.Article = this;
		}
		
		private void detach_Ref_Order_Article(Ref_Order_Article entity)
		{
			this.SendPropertyChanging();
			entity.Article = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Article_Type")]
	public partial class Article_Type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private EntitySet<Article> _Article;
		
		private EntityRef<Article_Type> _Article_Type2;
		
		private EntityRef<Article_Type> _Article_Type1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public Article_Type()
		{
			this._Article = new EntitySet<Article>(new Action<Article>(this.attach_Article), new Action<Article>(this.detach_Article));
			this._Article_Type2 = default(EntityRef<Article_Type>);
			this._Article_Type1 = default(EntityRef<Article_Type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._Article_Type1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Type_Article", Storage="_Article", ThisKey="Id", OtherKey="Id_Article_Type")]
		public EntitySet<Article> Article
		{
			get
			{
				return this._Article;
			}
			set
			{
				this._Article.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Type_Article_Type", Storage="_Article_Type2", ThisKey="Id", OtherKey="Id", IsUnique=true, IsForeignKey=false)]
		public Article_Type Article_Type2
		{
			get
			{
				return this._Article_Type2.Entity;
			}
			set
			{
				Article_Type previousValue = this._Article_Type2.Entity;
				if (((previousValue != value) 
							|| (this._Article_Type2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Article_Type2.Entity = null;
						previousValue.Article_Type1 = null;
					}
					this._Article_Type2.Entity = value;
					if ((value != null))
					{
						value.Article_Type1 = this;
					}
					this.SendPropertyChanged("Article_Type2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Type_Article_Type", Storage="_Article_Type1", ThisKey="Id", OtherKey="Id", IsForeignKey=true)]
		public Article_Type Article_Type1
		{
			get
			{
				return this._Article_Type1.Entity;
			}
			set
			{
				Article_Type previousValue = this._Article_Type1.Entity;
				if (((previousValue != value) 
							|| (this._Article_Type1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Article_Type1.Entity = null;
						previousValue.Article_Type2 = null;
					}
					this._Article_Type1.Entity = value;
					if ((value != null))
					{
						value.Article_Type2 = this;
						this._Id = value.Id;
					}
					else
					{
						this._Id = default(int);
					}
					this.SendPropertyChanged("Article_Type1");
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
		
		private void attach_Article(Article entity)
		{
			this.SendPropertyChanging();
			entity.Article_Type = this;
		}
		
		private void detach_Article(Article entity)
		{
			this.SendPropertyChanging();
			entity.Article_Type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Id_Restaurant;
		
		private System.DateTime _Date;
		
		private EntitySet<Ref_Order_Article> _Ref_Order_Article;
		
		private EntityRef<Restaurant> _Restaurant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnId_RestaurantChanging(int value);
    partial void OnId_RestaurantChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Order()
		{
			this._Ref_Order_Article = new EntitySet<Ref_Order_Article>(new Action<Ref_Order_Article>(this.attach_Ref_Order_Article), new Action<Ref_Order_Article>(this.detach_Ref_Order_Article));
			this._Restaurant = default(EntityRef<Restaurant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Restaurant", DbType="Int NOT NULL")]
		public int Id_Restaurant
		{
			get
			{
				return this._Id_Restaurant;
			}
			set
			{
				if ((this._Id_Restaurant != value))
				{
					if (this._Restaurant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_RestaurantChanging(value);
					this.SendPropertyChanging();
					this._Id_Restaurant = value;
					this.SendPropertyChanged("Id_Restaurant");
					this.OnId_RestaurantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Ref_Order_Article", Storage="_Ref_Order_Article", ThisKey="Id", OtherKey="Id_Order")]
		public EntitySet<Ref_Order_Article> Ref_Order_Article
		{
			get
			{
				return this._Ref_Order_Article;
			}
			set
			{
				this._Ref_Order_Article.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Restaurant_Order", Storage="_Restaurant", ThisKey="Id_Restaurant", OtherKey="Id", IsForeignKey=true)]
		public Restaurant Restaurant
		{
			get
			{
				return this._Restaurant.Entity;
			}
			set
			{
				Restaurant previousValue = this._Restaurant.Entity;
				if (((previousValue != value) 
							|| (this._Restaurant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Restaurant.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._Restaurant.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._Id_Restaurant = value.Id;
					}
					else
					{
						this._Id_Restaurant = default(int);
					}
					this.SendPropertyChanged("Restaurant");
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
		
		private void attach_Ref_Order_Article(Ref_Order_Article entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Ref_Order_Article(Ref_Order_Article entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ref_Order_Article")]
	public partial class Ref_Order_Article : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Id_Article;
		
		private int _Id_Order;
		
		private EntityRef<Article> _Article;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnId_ArticleChanging(int value);
    partial void OnId_ArticleChanged();
    partial void OnId_OrderChanging(int value);
    partial void OnId_OrderChanged();
    #endregion
		
		public Ref_Order_Article()
		{
			this._Article = default(EntityRef<Article>);
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Article", DbType="Int NOT NULL")]
		public int Id_Article
		{
			get
			{
				return this._Id_Article;
			}
			set
			{
				if ((this._Id_Article != value))
				{
					if (this._Article.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_ArticleChanging(value);
					this.SendPropertyChanging();
					this._Id_Article = value;
					this.SendPropertyChanged("Id_Article");
					this.OnId_ArticleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Order", DbType="Int NOT NULL")]
		public int Id_Order
		{
			get
			{
				return this._Id_Order;
			}
			set
			{
				if ((this._Id_Order != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_OrderChanging(value);
					this.SendPropertyChanging();
					this._Id_Order = value;
					this.SendPropertyChanged("Id_Order");
					this.OnId_OrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Article_Ref_Order_Article", Storage="_Article", ThisKey="Id_Article", OtherKey="Id", IsForeignKey=true)]
		public Article Article
		{
			get
			{
				return this._Article.Entity;
			}
			set
			{
				Article previousValue = this._Article.Entity;
				if (((previousValue != value) 
							|| (this._Article.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Article.Entity = null;
						previousValue.Ref_Order_Article.Remove(this);
					}
					this._Article.Entity = value;
					if ((value != null))
					{
						value.Ref_Order_Article.Add(this);
						this._Id_Article = value.Id;
					}
					else
					{
						this._Id_Article = default(int);
					}
					this.SendPropertyChanged("Article");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Ref_Order_Article", Storage="_Order", ThisKey="Id_Order", OtherKey="Id", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Ref_Order_Article.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Ref_Order_Article.Add(this);
						this._Id_Order = value.Id;
					}
					else
					{
						this._Id_Order = default(int);
					}
					this.SendPropertyChanged("Order");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Restaurant")]
	public partial class Restaurant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Restaurant()
		{
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Restaurant_Order", Storage="_Order", ThisKey="Id", OtherKey="Id_Restaurant")]
		public EntitySet<Order> Order
		{
			get
			{
				return this._Order;
			}
			set
			{
				this._Order.Assign(value);
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
		
		private void attach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Restaurant = this;
		}
		
		private void detach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Restaurant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Database_Changes")]
	public partial class Database_Changes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _Date;
		
		private bool _Article_changed;
		
		private EntityRef<Database_Changes> _Database_Changes2;
		
		private EntityRef<Database_Changes> _Database_Changes1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnArticle_changedChanging(bool value);
    partial void OnArticle_changedChanged();
    #endregion
		
		public Database_Changes()
		{
			this._Database_Changes2 = default(EntityRef<Database_Changes>);
			this._Database_Changes1 = default(EntityRef<Database_Changes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					if (this._Database_Changes1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Article_changed", DbType="Bit NOT NULL")]
		public bool Article_changed
		{
			get
			{
				return this._Article_changed;
			}
			set
			{
				if ((this._Article_changed != value))
				{
					this.OnArticle_changedChanging(value);
					this.SendPropertyChanging();
					this._Article_changed = value;
					this.SendPropertyChanged("Article_changed");
					this.OnArticle_changedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Database_Changes_Database_Changes", Storage="_Database_Changes2", ThisKey="Id", OtherKey="Id", IsUnique=true, IsForeignKey=false)]
		public Database_Changes Database_Changes2
		{
			get
			{
				return this._Database_Changes2.Entity;
			}
			set
			{
				Database_Changes previousValue = this._Database_Changes2.Entity;
				if (((previousValue != value) 
							|| (this._Database_Changes2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Database_Changes2.Entity = null;
						previousValue.Database_Changes1 = null;
					}
					this._Database_Changes2.Entity = value;
					if ((value != null))
					{
						value.Database_Changes1 = this;
					}
					this.SendPropertyChanged("Database_Changes2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Database_Changes_Database_Changes", Storage="_Database_Changes1", ThisKey="Id", OtherKey="Id", IsForeignKey=true)]
		public Database_Changes Database_Changes1
		{
			get
			{
				return this._Database_Changes1.Entity;
			}
			set
			{
				Database_Changes previousValue = this._Database_Changes1.Entity;
				if (((previousValue != value) 
							|| (this._Database_Changes1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Database_Changes1.Entity = null;
						previousValue.Database_Changes2 = null;
					}
					this._Database_Changes1.Entity = value;
					if ((value != null))
					{
						value.Database_Changes2 = this;
						this._Id = value.Id;
					}
					else
					{
						this._Id = default(int);
					}
					this.SendPropertyChanged("Database_Changes1");
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
