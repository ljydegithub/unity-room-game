using UnityEngine;
using QFramework;
using DG.Tweening;
using UniRx;
using System;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class Flashlight : ViewController
	{
		void Start()
		{
			// Code Here
			Observable.EveryUpdate()
        	.Where(_=>(SelectToolsName.Instance().selectToolName.Equals("Flashlight")&&SelectToolsName.Instance().selectToolOpen))
			.Subscribe(_=>{
				UIKit.OpenPanel<UITitlePanel>();
				SelectToolsName.Instance().selectToolOpen=false;
				UIKit.GetPanel<UITitlePanel>().title.Value="一个破旧的手电筒";
        	});
		}

		private void OnMouseDown() {
			//添加音乐
			AudioKit.PlaySound("clickSound");
			GetComponent<PolygonCollider2D>().enabled=false;
			transform.DOMove(new Vector3(0,0,0),1);
			transform.DORotate(Vector3.zero,1);
			//设置图层
			SpriteRenderer keySpriteRenderer=GetComponent<SpriteRenderer>();
			keySpriteRenderer.sortingOrder=30;
			//提示字幕  打开UIMessage
			UIKit.OpenPanel<UIMessagePanel>();
			UIKit.GetPanel<UIMessagePanel>().text.Value="获得一把破旧的手电筒";
			
			Observable.EveryUpdate()
			.Where(_=>((transform.position==Vector3.zero)))
			.Delay(TimeSpan.FromSeconds(0.5))
			.First()
			.Subscribe(_=>{
				transform.DOMove(new Vector3(7,5,0),1);
				transform.DORotate(Vector3.zero,1);
				transform.DOScale(Vector3.zero,1);

				Observable.Timer(TimeSpan.FromSeconds(1))
				.First()
				.Subscribe(destroy=>{
					//把钥匙放到UITools
					UIKit.GetPanel<UIToolsPanel>().collection.Add("Flashlight");
					gameObject.SetActive(false);
				});
				
			});
		}
	}
}
