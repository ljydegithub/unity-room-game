using UnityEngine;
using QFramework;
using UniRx;


// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class HotBox : ViewController
	{
		void Start()
		{
			//关闭页面
			Observable.EveryUpdate()
			.Where(_=>(CancelFive.isClose==true))
			.Subscribe(_=>{
				CancelView.gameObject.SetActive(false);
				CancelFive.isClose=false;
			});
		}

		private void OnMouseDown() {
			transform.position=transform.position+new Vector3(1.88f,0,0);
			gameObject.GetComponent<BoxCollider2D>().enabled=false;
			//把下面的乐谱显现出来
			PianoKeyFive.transform.position=transform.position-new Vector3(1.88f,0,0);
			CancelFive.transform.position=transform.position-new Vector3(3.05f,0,0);
			PianoKeyFive.enabled=true;
			//把乐谱的组件激活
			PianoKeyFive.GetComponent<BoxCollider2D>().enabled=true;
		}

		public void ShowView(){
			CancelView.gameObject.SetActive(true);
		}
	}
}
