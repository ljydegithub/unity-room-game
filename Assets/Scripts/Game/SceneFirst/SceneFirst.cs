using UnityEngine;
using QFramework;
using UniRx;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class SceneFirst : ViewController
	{
		void Start()
		{
			//把场景一预制体加入到字典
			Scenes.Instance().scene.Add("SceneFirst",gameObject);

			// 报纸掀开后给钥匙添加collider
			Observable.EveryUpdate()
			.Where(_=>(newspaper.transform.position.x==-8))
			.First()
			.Subscribe(_=>{
				SilverKey.gameObject.AddComponent<PolygonCollider2D>();
			});

			//花盆移动后给钥匙添加collider
			Observable.EveryUpdate()
			.Where(_=>(Flowerpot.transform.position.x==5))
			.First()
			.Subscribe(_=>{
				IronKey.gameObject.AddComponent<PolygonCollider2D>();
			});
		}
	}
}
