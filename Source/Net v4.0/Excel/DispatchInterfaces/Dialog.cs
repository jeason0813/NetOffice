//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Dialog SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Dialog : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Dialog(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Dialog(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Dialog(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Dialog()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Arg1">optional object Arg1</param>
		/// <param name="Arg2">optional object Arg2</param>
		/// <param name="Arg3">optional object Arg3</param>
		/// <param name="Arg4">optional object Arg4</param>
		/// <param name="Arg5">optional object Arg5</param>
		/// <param name="Arg6">optional object Arg6</param>
		/// <param name="Arg7">optional object Arg7</param>
		/// <param name="Arg8">optional object Arg8</param>
		/// <param name="Arg9">optional object Arg9</param>
		/// <param name="Arg10">optional object Arg10</param>
		/// <param name="Arg11">optional object Arg11</param>
		/// <param name="Arg12">optional object Arg12</param>
		/// <param name="Arg13">optional object Arg13</param>
		/// <param name="Arg14">optional object Arg14</param>
		/// <param name="Arg15">optional object Arg15</param>
		/// <param name="Arg16">optional object Arg16</param>
		/// <param name="Arg17">optional object Arg17</param>
		/// <param name="Arg18">optional object Arg18</param>
		/// <param name="Arg19">optional object Arg19</param>
		/// <param name="Arg20">optional object Arg20</param>
		/// <param name="Arg21">optional object Arg21</param>
		/// <param name="Arg22">optional object Arg22</param>
		/// <param name="Arg23">optional object Arg23</param>
		/// <param name="Arg24">optional object Arg24</param>
		/// <param name="Arg25">optional object Arg25</param>
		/// <param name="Arg26">optional object Arg26</param>
		/// <param name="Arg27">optional object Arg27</param>
		/// <param name="Arg28">optional object Arg28</param>
		/// <param name="Arg29">optional object Arg29</param>
		/// <param name="Arg30">optional object Arg30</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool Show(object arg1=null, object arg2=null, object arg3=null, object arg4=null, object arg5=null, object arg6=null, object arg7=null, object arg8=null, object arg9=null, object arg10=null, object arg11=null, object arg12=null, object arg13=null, object arg14=null, object arg15=null, object arg16=null, object arg17=null, object arg18=null, object arg19=null, object arg20=null, object arg21=null, object arg22=null, object arg23=null, object arg24=null, object arg25=null, object arg26=null, object arg27=null, object arg28=null, object arg29=null, object arg30=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			object returnItem = Invoker.MethodReturn(this, "Show", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool Show()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Show", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}