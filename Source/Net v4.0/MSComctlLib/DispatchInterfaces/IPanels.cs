//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IPanels SupportByLibrary MSComctlLib, 6
	///</summary>
	[SupportByLibrary("MSComctlLib", 6)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IPanels : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPanels(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPanels(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPanels(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPanels()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public Int16 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Count", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IPanel get_ControlDefault(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ControlDefault", paramsArray);
			NetOffice.MSComctlLibApi.IPanel newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IPanel;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public void set_ControlDefault(object index, NetOffice.MSComctlLibApi.IPanel value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.PropertySet(this, "ControlDefault", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("MSComctlLib", 6)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSComctlLibApi.IPanel this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSComctlLibApi.IPanel newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IPanel;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		/// <param name="Text">optional object Text</param>
		/// <param name="Style">optional object Style</param>
		/// <param name="Picture">optional object Picture</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IPanel Add(object index=null, object key=null, object text=null, object style=null, object picture=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text, style, picture);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IPanel newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IPanel;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IPanel Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IPanel newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IPanel;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public void Remove(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("MSComctlLib", 6)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}