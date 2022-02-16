using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	public class UIQuitGamePanelData : UIPanelData
	{
	}
	public partial class UIQuitGamePanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIQuitGamePanelData ?? new UIQuitGamePanelData();
			// please add init code here

			//添加按钮监听事件
			//1.点击取消按钮
			Cancel.onClick.AddListener(()=>{
				UIKit.ClosePanel<UIQuitGamePanel>();
			});
			//2.点击确定按钮
			Confirm.onClick.AddListener(()=>{
				Application.Quit();
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
