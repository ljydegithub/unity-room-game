using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:503a846b-1a57-4948-a667-8b52818ac959
	public partial class UIToolsPanel
	{
		public const string Name = "UIToolsPanel";
		
		[SerializeField]
		public UnityEngine.UI.Image Item01;
		[SerializeField]
		public UnityEngine.UI.Image Item02;
		[SerializeField]
		public UnityEngine.UI.Image Item03;
		[SerializeField]
		public UnityEngine.UI.Image Item04;
		[SerializeField]
		public UnityEngine.UI.Image Item05;
		[SerializeField]
		public UnityEngine.UI.Image Item06;
		[SerializeField]
		public UnityEngine.UI.Image Item07;
		[SerializeField]
		public UnityEngine.UI.Image Item08;
		[SerializeField]
		public UnityEngine.UI.Image Item09;
		[SerializeField]
		public UnityEngine.UI.Image Item10;
		[SerializeField]
		public UnityEngine.UI.Button Setting;
		
		private UIToolsPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			Item01 = null;
			Item02 = null;
			Item03 = null;
			Item04 = null;
			Item05 = null;
			Item06 = null;
			Item07 = null;
			Item08 = null;
			Item09 = null;
			Item10 = null;
			Setting = null;
			
			mData = null;
		}
		
		public UIToolsPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIToolsPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIToolsPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
