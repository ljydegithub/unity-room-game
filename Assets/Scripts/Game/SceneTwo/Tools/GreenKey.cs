using UnityEngine;
using QFramework;
using UniRx;
using DG.Tweening;
using System;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class GreenKey : ViewController
	{
		 // Start is called before the first frame update
		void Start()
		{
			Observable.EveryUpdate()
			.Where(_=>(SelectToolsName.Instance().selectToolName.Equals("GreenKey")&&SelectToolsName.Instance().selectToolOpen))
			.Subscribe(_=>{
				UIKit.OpenPanel<UITitlePanel>();
				UIKit.GetPanel<UITitlePanel>().title.Value="一把绿色的钥匙";
				SelectToolsName.Instance().selectToolOpen=false;
			});
		}

		// Update is called once per frame
		void Update()
		{
			
		}

		private void OnMouseDown() {
			//添加音乐
			AudioKit.PlaySound("clickSound");
			GetComponent<BoxCollider2D>().enabled=false;
			transform.DOMove(new Vector3(0,0,0),1);
			transform.DORotate(Vector3.zero,1);
			//设置图层
			SpriteRenderer keySpriteRenderer=GetComponent<SpriteRenderer>();
			keySpriteRenderer.sortingOrder=31;
			//提示字幕  打开UIMessage
			UIKit.OpenPanel<UIMessagePanel>();
			UIKit.GetPanel<UIMessagePanel>().text.Value="获得一把绿色钥匙";
			
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
					UIKit.GetPanel<UIToolsPanel>().collection.Add("GreenKey");
					Destroy(this.gameObject);
				});
				
			});
		
		}
	}
}
