using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:ad79d4e5-f4bd-421b-b9a1-f1d4f6232f30
	public partial class UITitlePanel
	{
		public const string Name = "UITitlePanel";
		
		[SerializeField]
		public UnityEngine.UI.Text ToolsTitle;
		
		private UITitlePanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			ToolsTitle = null;
			
			mData = null;
		}
		
		public UITitlePanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UITitlePanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UITitlePanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
