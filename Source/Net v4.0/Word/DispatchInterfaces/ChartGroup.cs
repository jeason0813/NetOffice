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
	/// DispatchInterface ChartGroup SupportByLibrary Word, 14
	///</summary>
	[SupportByLibrary("Word", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChartGroup : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartGroup()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.Enums.XlAxisGroup AxisGroup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AxisGroup", paramsArray);
				return (NetOffice.WordApi.Enums.XlAxisGroup)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AxisGroup", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 DoughnutHoleSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DoughnutHoleSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DoughnutHoleSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.DownBars DownBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DownBars", paramsArray);
				NetOffice.WordApi.DownBars newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.DownBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.DropLines DropLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DropLines", paramsArray);
				NetOffice.WordApi.DropLines newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.DropLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 FirstSliceAngle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstSliceAngle", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FirstSliceAngle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 GapWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GapWidth", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GapWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool HasDropLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasDropLines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasDropLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool HasHiLoLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasHiLoLines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasHiLoLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool HasRadarAxisLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasRadarAxisLabels", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasRadarAxisLabels", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool HasSeriesLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasSeriesLines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasSeriesLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool HasUpDownBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasUpDownBars", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasUpDownBars", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.HiLoLines HiLoLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HiLoLines", paramsArray);
				NetOffice.WordApi.HiLoLines newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.HiLoLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 Overlap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Overlap", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Overlap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.TickLabels RadarAxisLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RadarAxisLabels", paramsArray);
				NetOffice.WordApi.TickLabels newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.TickLabels;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.SeriesLines SeriesLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SeriesLines", paramsArray);
				NetOffice.WordApi.SeriesLines newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.SeriesLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 SubType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SubType", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SubType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.UpBars UpBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UpBars", paramsArray);
				NetOffice.WordApi.UpBars newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.UpBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool VaryByCategories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VaryByCategories", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VaryByCategories", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.Enums.XlSizeRepresents SizeRepresents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SizeRepresents", paramsArray);
				return (NetOffice.WordApi.Enums.XlSizeRepresents)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SizeRepresents", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 BubbleScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BubbleScale", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BubbleScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool ShowNegativeBubbles
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowNegativeBubbles", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowNegativeBubbles", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.Enums.XlChartSplitType SplitType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SplitType", paramsArray);
				return (NetOffice.WordApi.Enums.XlChartSplitType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SplitType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public object SplitValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SplitValue", paramsArray);
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
				Invoker.PropertySet(this, "SplitValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public Int32 SecondPlotSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SecondPlotSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SecondPlotSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool Has3DShading
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Has3DShading", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Has3DShading", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
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
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
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
		/// SupportByLibrary Word 14
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[SupportByLibrary("Word", 14)]
		public COMObject SeriesCollection(object index=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "SeriesCollection", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public COMObject SeriesCollection()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "SeriesCollection", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}