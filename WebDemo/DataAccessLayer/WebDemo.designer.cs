﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDemo.DataAccessLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebDemo")]
	public partial class WebDemoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertJapaneseWordEntry(JapaneseWordEntry instance);
    partial void UpdateJapaneseWordEntry(JapaneseWordEntry instance);
    partial void DeleteJapaneseWordEntry(JapaneseWordEntry instance);
    #endregion
		
		public WebDemoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebDemoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WebDemoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebDemoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebDemoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebDemoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<JapaneseWordEntry> JapaneseWordEntries
		{
			get
			{
				return this.GetTable<JapaneseWordEntry>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JapaneseWordEntry")]
	public partial class JapaneseWordEntry : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EntryId;
		
		private string _Hiragana;
		
		private string _Romaji;
		
		private string _Kanji;
		
		private string _AdditionalText;
		
		private string _MotherTongueTranslation;
		
		private string _MotherTongueTranslationLabel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEntryIdChanging(int value);
    partial void OnEntryIdChanged();
    partial void OnHiraganaChanging(string value);
    partial void OnHiraganaChanged();
    partial void OnRomajiChanging(string value);
    partial void OnRomajiChanged();
    partial void OnKanjiChanging(string value);
    partial void OnKanjiChanged();
    partial void OnAdditionalTextChanging(string value);
    partial void OnAdditionalTextChanged();
    partial void OnMotherTongueTranslationChanging(string value);
    partial void OnMotherTongueTranslationChanged();
    partial void OnMotherTongueTranslationLabelChanging(string value);
    partial void OnMotherTongueTranslationLabelChanged();
    #endregion
		
		public JapaneseWordEntry()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EntryId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EntryId
		{
			get
			{
				return this._EntryId;
			}
			set
			{
				if ((this._EntryId != value))
				{
					this.OnEntryIdChanging(value);
					this.SendPropertyChanging();
					this._EntryId = value;
					this.SendPropertyChanged("EntryId");
					this.OnEntryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hiragana", DbType="NVarChar(MAX)")]
		public string Hiragana
		{
			get
			{
				return this._Hiragana;
			}
			set
			{
				if ((this._Hiragana != value))
				{
					this.OnHiraganaChanging(value);
					this.SendPropertyChanging();
					this._Hiragana = value;
					this.SendPropertyChanged("Hiragana");
					this.OnHiraganaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Romaji", DbType="NVarChar(MAX)")]
		public string Romaji
		{
			get
			{
				return this._Romaji;
			}
			set
			{
				if ((this._Romaji != value))
				{
					this.OnRomajiChanging(value);
					this.SendPropertyChanging();
					this._Romaji = value;
					this.SendPropertyChanged("Romaji");
					this.OnRomajiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kanji", DbType="NVarChar(MAX)")]
		public string Kanji
		{
			get
			{
				return this._Kanji;
			}
			set
			{
				if ((this._Kanji != value))
				{
					this.OnKanjiChanging(value);
					this.SendPropertyChanging();
					this._Kanji = value;
					this.SendPropertyChanged("Kanji");
					this.OnKanjiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdditionalText", DbType="NVarChar(MAX)")]
		public string AdditionalText
		{
			get
			{
				return this._AdditionalText;
			}
			set
			{
				if ((this._AdditionalText != value))
				{
					this.OnAdditionalTextChanging(value);
					this.SendPropertyChanging();
					this._AdditionalText = value;
					this.SendPropertyChanged("AdditionalText");
					this.OnAdditionalTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherTongueTranslation", DbType="NVarChar(MAX)")]
		public string MotherTongueTranslation
		{
			get
			{
				return this._MotherTongueTranslation;
			}
			set
			{
				if ((this._MotherTongueTranslation != value))
				{
					this.OnMotherTongueTranslationChanging(value);
					this.SendPropertyChanging();
					this._MotherTongueTranslation = value;
					this.SendPropertyChanged("MotherTongueTranslation");
					this.OnMotherTongueTranslationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherTongueTranslationLabel", DbType="NVarChar(MAX)")]
		public string MotherTongueTranslationLabel
		{
			get
			{
				return this._MotherTongueTranslationLabel;
			}
			set
			{
				if ((this._MotherTongueTranslationLabel != value))
				{
					this.OnMotherTongueTranslationLabelChanging(value);
					this.SendPropertyChanging();
					this._MotherTongueTranslationLabel = value;
					this.SendPropertyChanged("MotherTongueTranslationLabel");
					this.OnMotherTongueTranslationLabelChanged();
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
