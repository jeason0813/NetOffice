//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface MailingLabel SupportByLibrary Word, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class MailingLabel : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool DefaultPrintBarCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultPrintBarCode", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultPrintBarCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdPaperTray DefaultLaserTray
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultLaserTray", paramsArray);
				return (NetOffice.WordApi.Enums.WdPaperTray)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultLaserTray", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.CustomLabels CustomLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomLabels", paramsArray);
				NetOffice.WordApi.CustomLabels newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.CustomLabels;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public string DefaultLabelName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultLabelName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultLabelName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool Vertical
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Vertical", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Vertical", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		[SupportByLibrary("Word", 9)]
		public NetOffice.WordApi.Document CreateNewDocument(object name=null, object address=null, object autoText=null, object extractAddress=null, object laserTray=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, autoText, extractAddress, laserTray);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		/// <param name="PrintEPostageLabel">optional object PrintEPostageLabel</param>
		/// <param name="Vertical">optional object Vertical</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Document CreateNewDocument(object name=null, object address=null, object autoText=null, object extractAddress=null, object laserTray=null, object printEPostageLabel=null, object vertical=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, autoText, extractAddress, laserTray, printEPostageLabel, vertical);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Document CreateNewDocument()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		/// <param name="SingleLabel">optional object SingleLabel</param>
		/// <param name="Row">optional object Row</param>
		/// <param name="Column">optional object Column</param>
		[SupportByLibrary("Word", 9)]
		public void PrintOut(object name=null, object address=null, object extractAddress=null, object laserTray=null, object singleLabel=null, object row=null, object column=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, extractAddress, laserTray, singleLabel, row, column);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		/// <param name="SingleLabel">optional object SingleLabel</param>
		/// <param name="Row">optional object Row</param>
		/// <param name="Column">optional object Column</param>
		/// <param name="PrintEPostageLabel">optional object PrintEPostageLabel</param>
		/// <param name="Vertical">optional object Vertical</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void PrintOut(object name=null, object address=null, object extractAddress=null, object laserTray=null, object singleLabel=null, object row=null, object column=null, object printEPostageLabel=null, object vertical=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, extractAddress, laserTray, singleLabel, row, column, printEPostageLabel, vertical);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Document CreateNewDocument2000(object name=null, object address=null, object autoText=null, object extractAddress=null, object laserTray=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, autoText, extractAddress, laserTray);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument2000", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Document CreateNewDocument2000()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument2000", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		/// <param name="SingleLabel">optional object SingleLabel</param>
		/// <param name="Row">optional object Row</param>
		/// <param name="Column">optional object Column</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void PrintOut2000(object name=null, object address=null, object extractAddress=null, object laserTray=null, object singleLabel=null, object row=null, object column=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, extractAddress, laserTray, singleLabel, row, column);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void PrintOut2000()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void LabelOptions()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "LabelOptions", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="LabelID">optional object LabelID</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		/// <param name="PrintEPostageLabel">optional object PrintEPostageLabel</param>
		/// <param name="Vertical">optional object Vertical</param>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Document CreateNewDocumentByID(object labelID=null, object address=null, object autoText=null, object extractAddress=null, object laserTray=null, object printEPostageLabel=null, object vertical=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(labelID, address, autoText, extractAddress, laserTray, printEPostageLabel, vertical);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocumentByID", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Document CreateNewDocumentByID()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocumentByID", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="LabelID">optional object LabelID</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="LaserTray">optional object LaserTray</param>
		/// <param name="SingleLabel">optional object SingleLabel</param>
		/// <param name="Row">optional object Row</param>
		/// <param name="Column">optional object Column</param>
		/// <param name="PrintEPostageLabel">optional object PrintEPostageLabel</param>
		/// <param name="Vertical">optional object Vertical</param>
		[SupportByLibrary("Word", 12,14)]
		public void PrintOutByID(object labelID=null, object address=null, object extractAddress=null, object laserTray=null, object singleLabel=null, object row=null, object column=null, object printEPostageLabel=null, object vertical=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(labelID, address, extractAddress, laserTray, singleLabel, row, column, printEPostageLabel, vertical);
			Invoker.Method(this, "PrintOutByID", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public void PrintOutByID()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOutByID", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}