using UnityEngine;
using QFramework;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class door03_0 : ViewController
	{
		void Start()
		{
			// Code Here
		}
		private void OnMouseDown() {
			if(SelectToolsName.Instance().selectToolName.Equals("IronKey")){
				ResLoader mResLoader = ResLoader.Allocate();
				//跟换贴图
				GetComponent<SpriteRenderer>().sprite=	mResLoader.LoadSync<Sprite>("door03_01");
				//最后销毁钥匙
            	UIKit.GetPanel<UIToolsPanel>().collection.Remove("IronKey");
			}
			if(GetComponent<SpriteRenderer>().sprite.name.Equals("door03_01")){
				//加载场景二，并隐藏场景三
				ResLoader mResLoader = ResLoader.Allocate();
				Scenes.Instance().scene["SceneThree"].SetActive(false);
				try{
					Scenes.Instance().scene["SceneTwo"].SetActive(true);
				}catch{
					mResLoader.LoadSync<GameObject> ("SceneTwo").Instantiate();
				}
			}
		}
	}
}
