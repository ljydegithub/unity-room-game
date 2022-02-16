using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:1cc9a48e-6f40-4d53-a898-1cc0d635635e
	public partial class UIHomePanel
	{
		public const string Name = "UIHomePanel";
		
		[SerializeField]
		public UnityEngine.UI.Button StartGameButton;
		[SerializeField]
		public UnityEngine.UI.Button SettingsButton;
		[SerializeField]
		public UnityEngine.UI.Button QuitGameButton;
		
		private UIHomePanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			StartGameButton = null;
			SettingsButton = null;
			QuitGameButton = null;
			
			mData = null;
		}
		
		public UIHomePanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIHomePanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIHomePanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
