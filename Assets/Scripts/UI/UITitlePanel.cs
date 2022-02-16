using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;
namespace QFramework.Example
{
	public class UITitlePanelData : UIPanelData
	{
	}
	public partial class UITitlePanel : UIPanel
	{
		public ReactiveProperty<string> title=new ReactiveProperty<string>("一二三四五六七八九十");
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UITitlePanelData ?? new UITitlePanelData();
			// please add init code here
			title.Subscribe(_=>{
				ToolsTitle.text=title.ToString();
				Observable.Timer(TimeSpan.FromSeconds(1))
				.Subscribe(close=>{
					UIKit.ClosePanel<UITitlePanel>();
				});
			});
		}
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
	}
}
