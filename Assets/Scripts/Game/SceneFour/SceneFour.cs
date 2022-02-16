using UnityEngine;
using QFramework;
using UniRx;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class SceneFour : ViewController
	{
		void Start()
		{
			// Code Here
			//把场景四预制体加入到字典
			Scenes.Instance().scene.Add("SceneFour",gameObject);

			//判断是否开灯给各个物体添加组件
			Observable.EveryUpdate()
			.Where(_=>(Lamplight.color.a==0))
			.Subscribe(_=>{
				if(PurpleSofa.gameObject.GetComponent<PurpleSofa>().enabled!=false){
					PurpleSofa.GetComponent<BoxCollider2D>().enabled=true;
				}
				Mirror.GetComponent<PolygonCollider2D>().enabled=true;
				Piano.GetComponent<PolygonCollider2D>().enabled=true;
				if(Flashlight.gameObject.activeSelf==true){
					Flashlight.GetComponent<PolygonCollider2D>().enabled=true;
				}
			});

			Observable.EveryUpdate()
			.Where(_=>(Lamplight.color.a==0.7f))
			.Subscribe(_=>{
				if(PurpleSofa.gameObject.GetComponent<PurpleSofa>().enabled!=false){
					PurpleSofa.GetComponent<BoxCollider2D>().enabled=false;
				}
				Piano.GetComponent<PolygonCollider2D>().enabled=false;
				if(Flashlight.gameObject.activeSelf==true){
					Flashlight.GetComponent<PolygonCollider2D>().enabled=false;
				}
			});

			//当沙发失活的时候，沙发二上场
			Observable.EveryUpdate()
			.Where(_=>(PurpleSofa.gameObject.GetComponent<PurpleSofa>().enabled==false))
			.First()
			.Subscribe(_=>{
				PurpleSofa02.GetComponent<SpriteRenderer>().enabled=true;
			});
		}
	}
}
