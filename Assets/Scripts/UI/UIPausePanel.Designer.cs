using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:f2a07419-9673-410f-a763-7acba999c6fa
	public partial class UIPausePanel
	{
		public const string Name = "UIPausePanel";
		
		[SerializeField]
		public UnityEngine.UI.Button ContinueButton;
		[SerializeField]
		public UnityEngine.UI.Button SettingsButton;
		[SerializeField]
		public UnityEngine.UI.Button QuitGameButton;
		
		private UIPausePanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			ContinueButton = null;
			SettingsButton = null;
			QuitGameButton = null;
			
			mData = null;
		}
		
		public UIPausePanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIPausePanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIPausePanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
