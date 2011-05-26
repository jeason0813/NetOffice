//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface MsoDebugOptions_UTs SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class MsoDebugOptions_UTs : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTs(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTs(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTs(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MsoDebugOptions_UTs()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Office", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.MsoDebugOptions_UT this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.MsoDebugOptions_UT newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.MsoDebugOptions_UT;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="bstrCollectionName">string bstrCollectionName</param>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.MsoDebugOptions_UTs GetUnitTestsInCollection(string bstrCollectionName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrCollectionName);
			object returnItem = Invoker.MethodReturn(this, "GetUnitTestsInCollection", paramsArray);
			NetOffice.OfficeApi.MsoDebugOptions_UTs newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.MsoDebugOptions_UTs;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="bstrCollectionName">string bstrCollectionName</param>
		/// <param name="bstrUnitTestName">string bstrUnitTestName</param>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.MsoDebugOptions_UT GetUnitTest(string bstrCollectionName, string bstrUnitTestName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrCollectionName, bstrUnitTestName);
			object returnItem = Invoker.MethodReturn(this, "GetUnitTest", paramsArray);
			NetOffice.OfficeApi.MsoDebugOptions_UT newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.MsoDebugOptions_UT;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="bstrCollectionName">string bstrCollectionName</param>
		/// <param name="bstrUnitTestNameFilter">string bstrUnitTestNameFilter</param>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.MsoDebugOptions_UTs GetMatchingUnitTestsInCollection(string bstrCollectionName, string bstrUnitTestNameFilter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrCollectionName, bstrUnitTestNameFilter);
			object returnItem = Invoker.MethodReturn(this, "GetMatchingUnitTestsInCollection", paramsArray);
			NetOffice.OfficeApi.MsoDebugOptions_UTs newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.MsoDebugOptions_UTs;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Office", 12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
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