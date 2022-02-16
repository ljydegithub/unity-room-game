using UnityEngine;
using QFramework;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class CurtainBigLeft : ViewController
	{
			//定义窗帘开关
		private bool CurtainIsOpen;
		private Sprite CurtainSmallSprite;
		private Sprite CurtainBigSprite;

		//定义BoxCollider2D
		BoxCollider2D curtainBoxCollider2D;
		// Start is called before the first frame update
		void Start()
		{
			ResLoader mResLoader = ResLoader.Allocate();
				// 获取小窗口图片
			CurtainSmallSprite=mResLoader.LoadSync<Sprite>("CurtainSmall");
			CurtainBigSprite=mResLoader.LoadSync<Sprite>("CurtainBig");
			CurtainIsOpen=true;
			//获取BoxCollider2D
			curtainBoxCollider2D=GetComponent<BoxCollider2D>();
		}

		private void OnMouseDown() {
			if(CurtainIsOpen){
				this.GetComponent<SpriteRenderer>().sprite=CurtainSmallSprite;
				CurtainIsOpen=false;
				transform.position=transform.position+new Vector3(-1,0,0);
				curtainBoxCollider2D.size=new Vector2(1,4);
			}else{
				this.GetComponent<SpriteRenderer>().sprite=CurtainBigSprite;
				CurtainIsOpen=true;
				transform.position=transform.position+new Vector3(1,0,0);
				curtainBoxCollider2D.size=new Vector2(3,4.125f);
			}
			
		}
	}
}
