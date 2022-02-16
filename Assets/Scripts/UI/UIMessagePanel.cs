using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;

namespace QFramework.Example
{
	public class UIMessagePanelData : UIPanelData
	{
	}
	public partial class UIMessagePanel : UIPanel
	{

		//创建text内容变量
		public ReactiveProperty<string> text=new ReactiveProperty<string>("一二三四五六七八九十");
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIMessagePanelData ?? new UIMessagePanelData();
			// please add init code here

			text.Subscribe(_=>{
				Message.text=text.ToString();
			});
		}
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
			Observable.EveryUpdate()
			.Where(_=>(Input.GetMouseButtonDown(0)))
			.First()
			.Subscribe(_=>{
				UIKit.HidePanel<UIMessagePanel>();
			});
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
	}
}
