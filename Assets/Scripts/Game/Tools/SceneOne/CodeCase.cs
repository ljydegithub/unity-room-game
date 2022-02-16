using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using QFramework.Example;

public class CodeCase : ViewController
{
    private Sprite CodeCaseSprite02;
    // Start is called before the first frame update
    void Start()
    {
        ResLoader mResLoader = ResLoader.Allocate();
        CodeCaseSprite02=mResLoader.LoadSync<Sprite>("codeCase02");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if(SelectToolsName.Instance().selectToolName.Equals("GreenKey")){
            transform.position=new Vector3(2.9f,-2.42f,0);
            GetComponent<SpriteRenderer>().sprite=CodeCaseSprite02;
            GetComponent<SpriteRenderer>().sortingOrder=0;
            GetComponent<BoxCollider2D>().enabled=false;
            //最后销毁钥匙
            UIKit.GetPanel<UIToolsPanel>().collection.Remove("GreenKey");
            //设置paper的boxcollider
            this.GetComponentInChildren<Transform>().position=new Vector3(0.54f,0,0);
            GetComponentInChildren<BoxCollider2D>().enabled=true;
        }else{
            Log.I("123");
        }
    }
}
