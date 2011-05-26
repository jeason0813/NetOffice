//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface _Index SupportByLibrary DAO, 6,12
	///</summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Index : _DAO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Index(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Index(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Index(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Index()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Foreign
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Foreign", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Unique
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Unique", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Unique", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Clustered
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Clustered", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Clustered", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Required
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Required", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Required", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool IgnoreNulls
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IgnoreNulls", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IgnoreNulls", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Primary
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Primary", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Primary", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 DistinctCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DistinctCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Fields", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Size">optional object Size</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Field CreateField(object name=null, object type=null, object size=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, size);
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Field CreateField()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Value">optional object Value</param>
		/// <param name="DDL">optional object DDL</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty(object name=null, object type=null, object value=null, object dDL=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, value, dDL);
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}