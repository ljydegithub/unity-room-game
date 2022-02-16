using UnityEngine;
using QFramework;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class Refrigerator : ViewController
	{
		void Start()
		{
			// Code Here
		}

		private void OnMouseDown() {
			ResLoader mResLoader = ResLoader.Allocate();
			//更换贴图并且移动位置
			GetComponent<SpriteRenderer>().sprite=mResLoader.LoadSync<Sprite>("Refrigerator02");
			transform.position=transform.position+new Vector3(1,0,0);
			//设置素材的order layer
			Vegetables.GetComponent<SpriteRenderer>().sortingOrder=3;
			Vegetables.transform.position=Vegetables.transform.position-new  Vector3(1,0.2f,0);
			//并关闭collider
			GetComponent<BoxCollider2D>().enabled=false;
		}
	}
}
