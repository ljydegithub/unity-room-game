using UnityEngine;
using QFramework;
using DG.Tweening;
// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class Trash : ViewController
	{
		void Start()
		{
			// Code Here
		}

		private void OnMouseDown() {
			transform.position=new Vector3(5.7f,-4,0);
			transform.DORotate(new Vector3(0,0,90),0.3f);
		}
	}
}
