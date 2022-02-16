using System.Runtime.InteropServices.ComTypes;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;

namespace QFramework.Example
{
	
	public class UIToolsPanelData : UIPanelData
	{
	}
	public partial class UIToolsPanel : UIPanel
	{
		//创建list集合添加Item
		public ReactiveCollection<String> collection = new ReactiveCollection<String>();
		List<Image> items=new List<Image>();
		ResLoader mResLoader = ResLoader.Allocate();

		private Sprite blackNull;
		protected override void ProcessMsg(int eventId, QMsg msg)
		{
			throw new System.NotImplementedException();
		}
		
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIToolsPanelData ?? new UIToolsPanelData();
			// please add init code here
			//初始话按钮
			initButton();
			//按钮选项
			items=addItems();
			collection.ObserveAdd()
			.Subscribe(_=>{
				foreach (var item in items)
				{
					if(item.sprite.name=="null"){
						item.sprite=mResLoader.LoadSync<Sprite>(collection[collection.Count-1]);
						break;
					}
				}
			});

			blackNull=mResLoader.LoadSync<Sprite>("null");
			//使用后的道具被移除后
			collection.ObserveRemove()
			.Subscribe(_=>{
				int i=0;
				foreach (var item in items)
				{
					if(collection.Count!=0){
						if(i<collection.Count){
							item.sprite=mResLoader.LoadSync<Sprite>(collection[i]);
						}else if(item.name!="null"){
							item.sprite=mResLoader.LoadSync<Sprite>("null");
						}
					}else{
						item.sprite=mResLoader.LoadSync<Sprite>("null");
					}
					i++;
				}
				//把selectToolName设置为空
				SelectToolsName.Instance().selectToolName="null";
			});

			//设置按钮点击事件
			Setting.onClick.AddListener(()=>{
				Time.timeScale=0;
				UIKit.OpenPanel<UIPausePanel>();
			});
		}
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
		//把item添加到集合
		private List<Image> addItems(){
			List<Image> list=new List<Image>();
			list.Add(Item01);
			list.Add(Item02);
			list.Add(Item03);
			list.Add(Item04);
			list.Add(Item05);
			list.Add(Item06);
			list.Add(Item07);
			list.Add(Item08);
			list.Add(Item09);
			list.Add(Item10);
			return list;
		}
		//初始化按钮
		private void initButton(){
			Item01.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item01.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item02.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item02.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item03.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item03.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item04.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item04.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item05.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item05.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item06.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item06.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item07.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item07.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item08.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item08.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item09.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item09.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
			Item10.GetComponent<Button>().onClick.AddListener(()=>{
				SelectToolsName.Instance().selectToolName=Item10.sprite.name;
				SelectToolsName.Instance().selectToolOpen=true;
			});
		}
	}
}
