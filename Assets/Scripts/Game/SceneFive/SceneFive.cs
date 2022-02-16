using UnityEngine;
using QFramework;
using UniRx;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class SceneFive : ViewController
	{
		void Start()
		{
			// Code Here
			//把场景五预制体加入到字典
			Scenes.Instance().scene.Add("SceneFive",gameObject);


			Observable.EveryUpdate()
			.Where(_=>(Glove.gameObject.activeSelf==false))
			.First()
			.Subscribe(_=>{
				HotBox.GetComponent<BoxCollider2D>().enabled=true;
			});

		}
	}
}
