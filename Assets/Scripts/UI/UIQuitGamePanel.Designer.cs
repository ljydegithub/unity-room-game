using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:c2ecead9-20e9-462d-93dd-3b6b24e1d2e3
	public partial class UIQuitGamePanel
	{
		public const string Name = "UIQuitGamePanel";
		
		[SerializeField]
		public UnityEngine.UI.Button Cancel;
		[SerializeField]
		public UnityEngine.UI.Button Confirm;
		
		private UIQuitGamePanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			Cancel = null;
			Confirm = null;
			
			mData = null;
		}
		
		public UIQuitGamePanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIQuitGamePanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIQuitGamePanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
