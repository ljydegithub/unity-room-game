using UnityEngine;
using QFramework;
using DG.Tweening;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class Flowerpot : ViewController
	{
		void Start()
		{
			// Code Here
		}

		private void OnMouseDown() {
			GetComponent<BoxCollider2D>().enabled=false;
			transform.DOMove(new Vector3(5,-1.69f,0),0.5f);
		}
	}
}
