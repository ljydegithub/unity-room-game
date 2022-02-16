using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	public class UIPausePanelData : UIPanelData
	{
	}
	public partial class UIPausePanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIPausePanelData ?? new UIPausePanelData();
			// please add init code here
			// 添加按钮事件
			//1.添加开始游戏按钮事件
			ContinueButton.onClick.AddListener(()=>{
				//关闭UI页面
				Time.timeScale=1;
				UIKit.ClosePanel<UIPausePanel>();
			});
			//2.添加设置游戏按钮事件
			SettingsButton.onClick.AddListener(()=>{
				//跳转设置界面UI
				UIKit.OpenPanel<UISettingsPanel>();
			});
			//3.添加退出游戏按钮事件
			QuitGameButton.onClick.AddListener(()=>{
				//弹出退出界面
				UIKit.OpenPanel<UIQuitGamePanel>();
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
