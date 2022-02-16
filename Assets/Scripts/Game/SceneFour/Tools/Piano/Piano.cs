using UnityEngine;
using QFramework;
using UniRx;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class Piano : ViewController
	{
		public ReactiveProperty<string> code1=new ReactiveProperty<string>("");
		public ReactiveProperty<string> code2=new ReactiveProperty<string>("");
		public ReactiveProperty<string> code3=new ReactiveProperty<string>("");
		public ReactiveProperty<string> code4=new ReactiveProperty<string>("");

		public void ClearCode(){
			//清空code字符
			code1.Value=code2.Value=code3.Value=code4.Value="";
		}
		void Start()
		{
			// Code Here
			Observable.EveryUpdate()
			.Where(_=>(Cancel.isClose==true))
			.Subscribe(_=>{
				PianoKey.gameObject.SetActive(false);
				Cancel.isClose=false;
			});

			code4.Subscribe(_=>{
				Log.I("code1"+code1.Value+"code2"+code2.Value+"code3"+code3.Value+"code4"+code4.Value);
				if(code1.Value.Equals("六")&&code2.Value.Equals("三")&&code3.Value.Equals("五")&&code4.Value.Equals("一"))
				{
					Log.I("成功");
				}else{
					ClearCode();
				}
				code4.Value="";
			});
		}

		private void OnMouseDown() {
			PianoKey.gameObject.SetActive(true);
		}


		private void Update() {
			
		}
	}
}