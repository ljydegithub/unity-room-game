using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:80decac5-a61b-4c35-8adf-5de748d7fe6a
	public partial class UISettingsPanel
	{
		public const string Name = "UISettingsPanel";
		
		[SerializeField]
		public UnityEngine.UI.Toggle BgmToggle;
		[SerializeField]
		public UnityEngine.UI.Slider BgmSlider;
		[SerializeField]
		public UnityEngine.UI.Button Cancel;
		
		private UISettingsPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BgmToggle = null;
			BgmSlider = null;
			Cancel = null;
			
			mData = null;
		}
		
		public UISettingsPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UISettingsPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UISettingsPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
