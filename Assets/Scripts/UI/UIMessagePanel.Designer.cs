using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:c0b771fa-5338-4512-af38-24e65aea53fe
	public partial class UIMessagePanel
	{
		public const string Name = "UIMessagePanel";
		
		[SerializeField]
		public UnityEngine.UI.Text Message;
		
		private UIMessagePanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			Message = null;
			
			mData = null;
		}
		
		public UIMessagePanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIMessagePanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIMessagePanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
