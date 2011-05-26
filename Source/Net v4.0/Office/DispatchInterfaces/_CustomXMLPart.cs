//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface _CustomXMLPart SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CustomXMLPart : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CustomXMLPart()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode DocumentElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DocumentElement", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string Id
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Id", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string NamespaceURI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceURI", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLSchemaCollection SchemaCollection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SchemaCollection", paramsArray);
				NetOffice.OfficeApi.CustomXMLSchemaCollection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CustomXMLSchemaCollection;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SchemaCollection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLPrefixMappings NamespaceManager
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceManager", paramsArray);
				NetOffice.OfficeApi.CustomXMLPrefixMappings newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CustomXMLPrefixMappings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLValidationErrors Errors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Errors", paramsArray);
				NetOffice.OfficeApi.CustomXMLValidationErrors newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CustomXMLValidationErrors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool BuiltIn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuiltIn", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Parent">NetOffice.OfficeApi.CustomXMLNode Parent</param>
		/// <param name="Name">string Name</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		/// <param name="NextSibling">NetOffice.OfficeApi.CustomXMLNode NextSibling</param>
		/// <param name="NodeType">NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType</param>
		/// <param name="NodeValue">string NodeValue</param>
		[SupportByLibrary("Office", 12,14)]
		public void AddNode(NetOffice.OfficeApi.CustomXMLNode parent, string name, string namespaceURI, NetOffice.OfficeApi.CustomXMLNode nextSibling, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parent, name, namespaceURI, nextSibling, nodeType, nodeValue);
			Invoker.Method(this, "AddNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="FilePath">string FilePath</param>
		[SupportByLibrary("Office", 12,14)]
		public bool Load(string filePath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filePath);
			object returnItem = Invoker.MethodReturn(this, "Load", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XML">string XML</param>
		[SupportByLibrary("Office", 12,14)]
		public bool LoadXML(string xML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML);
			object returnItem = Invoker.MethodReturn(this, "LoadXML", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XPath">string XPath</param>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNodes SelectNodes(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CustomXMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="XPath">string XPath</param>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode SelectSingleNode(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CustomXMLNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}