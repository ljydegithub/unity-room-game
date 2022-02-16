using UnityEngine;
using QFramework;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class FloorLamp : ViewController
	{
		private SpriteRenderer lamplightSpriteRenderer;
		void Start()
		{
			// Code Here
			//获取子物件的SpriteRenderer
			lamplightSpriteRenderer=Lamplight.GetComponent<SpriteRenderer>();
		}

		private void OnMouseDown() {
			if(lamplightSpriteRenderer.color.a!=0){
				lamplightSpriteRenderer.color=new Vector4(1,1,1,0);
			}else if(lamplightSpriteRenderer.color.a==0){
				lamplightSpriteRenderer.color=new Vector4(1,1,1,0.7f);
			}
		}
	}
}
