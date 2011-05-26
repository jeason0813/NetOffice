//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void RemoteItem_OpenEventHandler(ref bool Cancel);
	public delegate void RemoteItem_CustomActionEventHandler(COMObject Action, COMObject Response, ref bool Cancel);
	public delegate void RemoteItem_CustomPropertyChangeEventHandler(string Name);
	public delegate void RemoteItem_ForwardEventHandler(COMObject Forward, ref bool Cancel);
	public delegate void RemoteItem_CloseEventHandler(ref bool Cancel);
	public delegate void RemoteItem_PropertyChangeEventHandler(string Name);
	public delegate void RemoteItem_ReadEventHandler();
	public delegate void RemoteItem_ReplyEventHandler(COMObject Response, ref bool Cancel);
	public delegate void RemoteItem_ReplyAllEventHandler(COMObject Response, ref bool Cancel);
	public delegate void RemoteItem_SendEventHandler(ref bool Cancel);
	public delegate void RemoteItem_WriteEventHandler(ref bool Cancel);
	public delegate void RemoteItem_BeforeCheckNamesEventHandler(ref bool Cancel);
	public delegate void RemoteItem_AttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void RemoteItem_AttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void RemoteItem_BeforeAttachmentSaveEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void RemoteItem_BeforeDeleteEventHandler(COMObject Item, ref bool Cancel);
	public delegate void RemoteItem_AttachmentRemoveEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void RemoteItem_BeforeAttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void RemoteItem_BeforeAttachmentPreviewEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void RemoteItem_BeforeAttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void RemoteItem_BeforeAttachmentWriteToTempFileEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void RemoteItem_UnloadEventHandler();
	public delegate void RemoteItem_BeforeAutoSaveEventHandler(ref bool Cancel);
	public delegate void RemoteItem_BeforeReadEventHandler();
	public delegate void RemoteItem_AfterWriteEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass RemoteItem SupportByLibrary Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class RemoteItem : _RemoteItem, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ItemEvents_SinkHelper _itemEvents_SinkHelper;
		ItemEvents_10_SinkHelper _itemEvents_10_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RemoteItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RemoteItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RemoteItem(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public RemoteItem()
		{
			CreateFromProgId("Outlook.RemoteItem");
		}
		
		/// <param name="progId">progId</param>
		public RemoteItem(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ItemEvents_SinkHelper.Id,ItemEvents_10_SinkHelper.Id);


			if(ItemEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_SinkHelper = new ItemEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(ItemEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_10_SinkHelper = new ItemEvents_10_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_CustomActionEventHandler _CustomActionEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_CustomActionEventHandler CustomActionEvent
		{
			add
			{
				CreateEventBridge();
				_CustomActionEvent += value;
			}
			remove
			{
				_CustomActionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_CustomPropertyChangeEventHandler _CustomPropertyChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_CustomPropertyChangeEventHandler CustomPropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_CustomPropertyChangeEvent += value;
			}
			remove
			{
				_CustomPropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_ForwardEventHandler _ForwardEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_ForwardEventHandler ForwardEvent
		{
			add
			{
				CreateEventBridge();
				_ForwardEvent += value;
			}
			remove
			{
				_ForwardEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_PropertyChangeEventHandler _PropertyChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_PropertyChangeEventHandler PropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PropertyChangeEvent += value;
			}
			remove
			{
				_PropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_ReadEventHandler _ReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_ReadEventHandler ReadEvent
		{
			add
			{
				CreateEventBridge();
				_ReadEvent += value;
			}
			remove
			{
				_ReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_ReplyEventHandler _ReplyEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_ReplyEventHandler ReplyEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyEvent += value;
			}
			remove
			{
				_ReplyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_ReplyAllEventHandler _ReplyAllEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_ReplyAllEventHandler ReplyAllEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyAllEvent += value;
			}
			remove
			{
				_ReplyAllEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_SendEventHandler _SendEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_SendEventHandler SendEvent
		{
			add
			{
				CreateEventBridge();
				_SendEvent += value;
			}
			remove
			{
				_SendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_WriteEventHandler _WriteEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_WriteEventHandler WriteEvent
		{
			add
			{
				CreateEventBridge();
				_WriteEvent += value;
			}
			remove
			{
				_WriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_BeforeCheckNamesEventHandler _BeforeCheckNamesEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_BeforeCheckNamesEventHandler BeforeCheckNamesEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCheckNamesEvent += value;
			}
			remove
			{
				_BeforeCheckNamesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_AttachmentAddEventHandler _AttachmentAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_AttachmentAddEventHandler AttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentAddEvent += value;
			}
			remove
			{
				_AttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_AttachmentReadEventHandler _AttachmentReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_AttachmentReadEventHandler AttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentReadEvent += value;
			}
			remove
			{
				_AttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event RemoteItem_BeforeAttachmentSaveEventHandler _BeforeAttachmentSaveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event RemoteItem_BeforeAttachmentSaveEventHandler BeforeAttachmentSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentSaveEvent += value;
			}
			remove
			{
				_BeforeAttachmentSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event RemoteItem_BeforeDeleteEventHandler _BeforeDeleteEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event RemoteItem_BeforeDeleteEventHandler BeforeDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDeleteEvent += value;
			}
			remove
			{
				_BeforeDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event RemoteItem_AttachmentRemoveEventHandler _AttachmentRemoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event RemoteItem_AttachmentRemoveEventHandler AttachmentRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentRemoveEvent += value;
			}
			remove
			{
				_AttachmentRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event RemoteItem_BeforeAttachmentAddEventHandler _BeforeAttachmentAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event RemoteItem_BeforeAttachmentAddEventHandler BeforeAttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentAddEvent += value;
			}
			remove
			{
				_BeforeAttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event RemoteItem_BeforeAttachmentPreviewEventHandler _BeforeAttachmentPreviewEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event RemoteItem_BeforeAttachmentPreviewEventHandler BeforeAttachmentPreviewEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentPreviewEvent += value;
			}
			remove
			{
				_BeforeAttachmentPreviewEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event RemoteItem_BeforeAttachmentReadEventHandler _BeforeAttachmentReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event RemoteItem_BeforeAttachmentReadEventHandler BeforeAttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentReadEvent += value;
			}
			remove
			{
				_BeforeAttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event RemoteItem_BeforeAttachmentWriteToTempFileEventHandler _BeforeAttachmentWriteToTempFileEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event RemoteItem_BeforeAttachmentWriteToTempFileEventHandler BeforeAttachmentWriteToTempFileEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentWriteToTempFileEvent += value;
			}
			remove
			{
				_BeforeAttachmentWriteToTempFileEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event RemoteItem_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event RemoteItem_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event RemoteItem_BeforeAutoSaveEventHandler _BeforeAutoSaveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event RemoteItem_BeforeAutoSaveEventHandler BeforeAutoSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAutoSaveEvent += value;
			}
			remove
			{
				_BeforeAutoSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 14
		/// </summary>
		private event RemoteItem_BeforeReadEventHandler _BeforeReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public event RemoteItem_BeforeReadEventHandler BeforeReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReadEvent += value;
			}
			remove
			{
				_BeforeReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 14
		/// </summary>
		private event RemoteItem_AfterWriteEventHandler _AfterWriteEvent;

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public event RemoteItem_AfterWriteEventHandler AfterWriteEvent
		{
			add
			{
				CreateEventBridge();
				_AfterWriteEvent += value;
			}
			remove
			{
				_AfterWriteEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _itemEvents_SinkHelper)
			{
				_itemEvents_SinkHelper.Dispose();
				_itemEvents_SinkHelper = null;
			}
			if( null != _itemEvents_10_SinkHelper)
			{
				_itemEvents_10_SinkHelper.Dispose();
				_itemEvents_10_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}