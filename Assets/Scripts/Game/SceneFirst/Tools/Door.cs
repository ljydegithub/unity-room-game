using UnityEngine;
using QFramework;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class Door : ViewController
	{
		private bool doorIsOpen;
		void Start()
		{
			doorIsOpen=false;
		}

		private void OnMouseDown() {
			if(SelectToolsName.Instance().selectToolName.Equals("SilverKey")&&!doorIsOpen){
				doorLeft.GetComponent<Animator>().enabled=true;
				doorRight.GetComponent<Animator>().enabled=true;
				doorIsOpen=true;
				//最后销毁钥匙
            	UIKit.GetPanel<UIToolsPanel>().collection.Remove("SilverKey");
			}else if(doorIsOpen){
				//加载场景三，并隐藏场景一
				ResLoader mResLoader = ResLoader.Allocate();
				Scenes.Instance().scene["SceneFirst"].SetActive(false);
				try{
					Scenes.Instance().scene["SceneThree"].SetActive(true);	
				}catch{
					mResLoader.LoadSync<GameObject> ("SceneThree").Instantiate();
				}
			}
		}

	}
}

