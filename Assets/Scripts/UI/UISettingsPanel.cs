using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;

namespace QFramework.Example
{
	public class UISettingsPanelData : UIPanelData
	{
	}
	public partial class UISettingsPanel : UIPanel
	{
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UISettingsPanelData ?? new UISettingsPanelData();
			// please add init code here
			// 添加音乐开关事件
			// 播放音乐
			BgmToggle.OnValueChangedAsObservable()
			.Where(on => on)
			.Subscribe(on=>{
				AudioKit.PlayMusic("bgm");
			});
			// 关闭音乐
			BgmToggle.OnValueChangedAsObservable()
			.Where(on => !on)
			.Subscribe(on=>{
				AudioKit.PauseMusic();
			});

			//调节音乐大小
			Observable.EveryUpdate()
			.Subscribe(_=>{
				AudioKit.Settings.MusicVolume.Value=BgmSlider.value/100;
			})
			.DisposeWhenGameObjectDestroyed(this);
			

			//点击取消按钮关闭页面
			Cancel.onClick.AddListener(()=>{
				UIKit.ClosePanel<UISettingsPanel>();
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
