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

namespace CapaDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbRoboMatrixUdla")]
	public partial class MERRobotDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTblCategoria(TblCategoria instance);
    partial void UpdateTblCategoria(TblCategoria instance);
    partial void DeleteTblCategoria(TblCategoria instance);
    partial void InsertTblEquipo(TblEquipo instance);
    partial void UpdateTblEquipo(TblEquipo instance);
    partial void DeleteTblEquipo(TblEquipo instance);
    partial void InsertTblRobot(TblRobot instance);
    partial void UpdateTblRobot(TblRobot instance);
    partial void DeleteTblRobot(TblRobot instance);
    #endregion
		
		public MERRobotDataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.dbRoboMatrixUdlaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MERRobotDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MERRobotDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MERRobotDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MERRobotDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblCategoria> TblCategorias
		{
			get
			{
				return this.GetTable<TblCategoria>();
			}
		}
		
		public System.Data.Linq.Table<TblEquipo> TblEquipos
		{
			get
			{
				return this.GetTable<TblEquipo>();
			}
		}
		
		public System.Data.Linq.Table<TblRobot> TblRobots
		{
			get
			{
				return this.GetTable<TblRobot>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblCategoria")]
	public partial class TblCategoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCat;
		
		private string _nomCat;
		
		private string _descripcion;
		
		private EntitySet<TblRobot> _TblRobots;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCatChanging(int value);
    partial void OnidCatChanged();
    partial void OnnomCatChanging(string value);
    partial void OnnomCatChanged();
    partial void OndescripcionChanging(string value);
    partial void OndescripcionChanged();
    #endregion
		
		public TblCategoria()
		{
			this._TblRobots = new EntitySet<TblRobot>(new Action<TblRobot>(this.attach_TblRobots), new Action<TblRobot>(this.detach_TblRobots));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCat", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCat
		{
			get
			{
				return this._idCat;
			}
			set
			{
				if ((this._idCat != value))
				{
					this.OnidCatChanging(value);
					this.SendPropertyChanging();
					this._idCat = value;
					this.SendPropertyChanged("idCat");
					this.OnidCatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomCat", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string nomCat
		{
			get
			{
				return this._nomCat;
			}
			set
			{
				if ((this._nomCat != value))
				{
					this.OnnomCatChanging(value);
					this.SendPropertyChanging();
					this._nomCat = value;
					this.SendPropertyChanged("nomCat");
					this.OnnomCatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="VarChar(500)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this.OndescripcionChanging(value);
					this.SendPropertyChanging();
					this._descripcion = value;
					this.SendPropertyChanged("descripcion");
					this.OndescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCategoria_TblRobot", Storage="_TblRobots", ThisKey="idCat", OtherKey="idCategoria")]
		public EntitySet<TblRobot> TblRobots
		{
			get
			{
				return this._TblRobots;
			}
			set
			{
				this._TblRobots.Assign(value);
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
		
		private void attach_TblRobots(TblRobot entity)
		{
			this.SendPropertyChanging();
			entity.TblCategoria = this;
		}
		
		private void detach_TblRobots(TblRobot entity)
		{
			this.SendPropertyChanging();
			entity.TblCategoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblEquipo")]
	public partial class TblEquipo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idEquipo;
		
		private string _nomEquipo;
		
		private string _paisEquipo;
		
		private string _lugarEquipo;
		
		private System.Data.Linq.Binary _imgEquipo;
		
		private EntitySet<TblRobot> _TblRobots;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidEquipoChanging(int value);
    partial void OnidEquipoChanged();
    partial void OnnomEquipoChanging(string value);
    partial void OnnomEquipoChanged();
    partial void OnpaisEquipoChanging(string value);
    partial void OnpaisEquipoChanged();
    partial void OnlugarEquipoChanging(string value);
    partial void OnlugarEquipoChanged();
    partial void OnimgEquipoChanging(System.Data.Linq.Binary value);
    partial void OnimgEquipoChanged();
    #endregion
		
		public TblEquipo()
		{
			this._TblRobots = new EntitySet<TblRobot>(new Action<TblRobot>(this.attach_TblRobots), new Action<TblRobot>(this.detach_TblRobots));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEquipo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idEquipo
		{
			get
			{
				return this._idEquipo;
			}
			set
			{
				if ((this._idEquipo != value))
				{
					this.OnidEquipoChanging(value);
					this.SendPropertyChanging();
					this._idEquipo = value;
					this.SendPropertyChanged("idEquipo");
					this.OnidEquipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomEquipo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nomEquipo
		{
			get
			{
				return this._nomEquipo;
			}
			set
			{
				if ((this._nomEquipo != value))
				{
					this.OnnomEquipoChanging(value);
					this.SendPropertyChanging();
					this._nomEquipo = value;
					this.SendPropertyChanged("nomEquipo");
					this.OnnomEquipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paisEquipo", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string paisEquipo
		{
			get
			{
				return this._paisEquipo;
			}
			set
			{
				if ((this._paisEquipo != value))
				{
					this.OnpaisEquipoChanging(value);
					this.SendPropertyChanging();
					this._paisEquipo = value;
					this.SendPropertyChanged("paisEquipo");
					this.OnpaisEquipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lugarEquipo", DbType="VarChar(50)")]
		public string lugarEquipo
		{
			get
			{
				return this._lugarEquipo;
			}
			set
			{
				if ((this._lugarEquipo != value))
				{
					this.OnlugarEquipoChanging(value);
					this.SendPropertyChanging();
					this._lugarEquipo = value;
					this.SendPropertyChanged("lugarEquipo");
					this.OnlugarEquipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imgEquipo", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary imgEquipo
		{
			get
			{
				return this._imgEquipo;
			}
			set
			{
				if ((this._imgEquipo != value))
				{
					this.OnimgEquipoChanging(value);
					this.SendPropertyChanging();
					this._imgEquipo = value;
					this.SendPropertyChanged("imgEquipo");
					this.OnimgEquipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblEquipo_TblRobot", Storage="_TblRobots", ThisKey="idEquipo", OtherKey="idEquipo")]
		public EntitySet<TblRobot> TblRobots
		{
			get
			{
				return this._TblRobots;
			}
			set
			{
				this._TblRobots.Assign(value);
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
		
		private void attach_TblRobots(TblRobot entity)
		{
			this.SendPropertyChanging();
			entity.TblEquipo = this;
		}
		
		private void detach_TblRobots(TblRobot entity)
		{
			this.SendPropertyChanging();
			entity.TblEquipo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblRobot")]
	public partial class TblRobot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idRobot;
		
		private string _nomRobot;
		
		private string _estadoRobot;
		
		private string _liderRobot;
		
		private int _idCategoria;
		
		private int _idEquipo;
		
		private EntityRef<TblCategoria> _TblCategoria;
		
		private EntityRef<TblEquipo> _TblEquipo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidRobotChanging(int value);
    partial void OnidRobotChanged();
    partial void OnnomRobotChanging(string value);
    partial void OnnomRobotChanged();
    partial void OnestadoRobotChanging(string value);
    partial void OnestadoRobotChanged();
    partial void OnliderRobotChanging(string value);
    partial void OnliderRobotChanged();
    partial void OnidCategoriaChanging(int value);
    partial void OnidCategoriaChanged();
    partial void OnidEquipoChanging(int value);
    partial void OnidEquipoChanged();
    #endregion
		
		public TblRobot()
		{
			this._TblCategoria = default(EntityRef<TblCategoria>);
			this._TblEquipo = default(EntityRef<TblEquipo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idRobot", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idRobot
		{
			get
			{
				return this._idRobot;
			}
			set
			{
				if ((this._idRobot != value))
				{
					this.OnidRobotChanging(value);
					this.SendPropertyChanging();
					this._idRobot = value;
					this.SendPropertyChanged("idRobot");
					this.OnidRobotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomRobot", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nomRobot
		{
			get
			{
				return this._nomRobot;
			}
			set
			{
				if ((this._nomRobot != value))
				{
					this.OnnomRobotChanging(value);
					this.SendPropertyChanging();
					this._nomRobot = value;
					this.SendPropertyChanged("nomRobot");
					this.OnnomRobotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estadoRobot", DbType="Char(2)")]
		public string estadoRobot
		{
			get
			{
				return this._estadoRobot;
			}
			set
			{
				if ((this._estadoRobot != value))
				{
					this.OnestadoRobotChanging(value);
					this.SendPropertyChanging();
					this._estadoRobot = value;
					this.SendPropertyChanged("estadoRobot");
					this.OnestadoRobotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_liderRobot", DbType="VarChar(25)")]
		public string liderRobot
		{
			get
			{
				return this._liderRobot;
			}
			set
			{
				if ((this._liderRobot != value))
				{
					this.OnliderRobotChanging(value);
					this.SendPropertyChanging();
					this._liderRobot = value;
					this.SendPropertyChanged("liderRobot");
					this.OnliderRobotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCategoria", DbType="Int NOT NULL")]
		public int idCategoria
		{
			get
			{
				return this._idCategoria;
			}
			set
			{
				if ((this._idCategoria != value))
				{
					if (this._TblCategoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCategoriaChanging(value);
					this.SendPropertyChanging();
					this._idCategoria = value;
					this.SendPropertyChanged("idCategoria");
					this.OnidCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEquipo", DbType="Int NOT NULL")]
		public int idEquipo
		{
			get
			{
				return this._idEquipo;
			}
			set
			{
				if ((this._idEquipo != value))
				{
					if (this._TblEquipo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidEquipoChanging(value);
					this.SendPropertyChanging();
					this._idEquipo = value;
					this.SendPropertyChanged("idEquipo");
					this.OnidEquipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblCategoria_TblRobot", Storage="_TblCategoria", ThisKey="idCategoria", OtherKey="idCat", IsForeignKey=true)]
		public TblCategoria TblCategoria
		{
			get
			{
				return this._TblCategoria.Entity;
			}
			set
			{
				TblCategoria previousValue = this._TblCategoria.Entity;
				if (((previousValue != value) 
							|| (this._TblCategoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblCategoria.Entity = null;
						previousValue.TblRobots.Remove(this);
					}
					this._TblCategoria.Entity = value;
					if ((value != null))
					{
						value.TblRobots.Add(this);
						this._idCategoria = value.idCat;
					}
					else
					{
						this._idCategoria = default(int);
					}
					this.SendPropertyChanged("TblCategoria");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TblEquipo_TblRobot", Storage="_TblEquipo", ThisKey="idEquipo", OtherKey="idEquipo", IsForeignKey=true)]
		public TblEquipo TblEquipo
		{
			get
			{
				return this._TblEquipo.Entity;
			}
			set
			{
				TblEquipo previousValue = this._TblEquipo.Entity;
				if (((previousValue != value) 
							|| (this._TblEquipo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TblEquipo.Entity = null;
						previousValue.TblRobots.Remove(this);
					}
					this._TblEquipo.Entity = value;
					if ((value != null))
					{
						value.TblRobots.Add(this);
						this._idEquipo = value.idEquipo;
					}
					else
					{
						this._idEquipo = default(int);
					}
					this.SendPropertyChanged("TblEquipo");
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
