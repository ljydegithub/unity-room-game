using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	public class UIHomePanelData : UIPanelData
	{
	}
	public partial class UIHomePanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIHomePanelData ?? new UIHomePanelData();
			// please add init code here

			// 添加按钮事件
			//1.添加开始游戏按钮事件
			StartGameButton.onClick.AddListener(()=>{
				//关闭UI页面
				UIKit.ClosePanel<UIHomePanel>();
				//开始游戏
				ResLoader mResLoader = ResLoader.Allocate();
				mResLoader.LoadSync<GameObject>("SceneFirst").Instantiate();
				//打开工具栏UI
				UIKit.OpenPanel<UIToolsPanel>();

				//设置开关时间和工具都为初始值
				SelectToolsName.Instance().selectToolName="null";
				SelectToolsName.Instance().selectToolOpen=false;
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
