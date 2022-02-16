using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using DG.Tweening;
using QFramework.Example;
using UniRx;
using System;

public class Paper : ViewController
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.EveryUpdate()
        .Where(_=>(SelectToolsName.Instance().selectToolName.Equals("paper")&&SelectToolsName.Instance().selectToolOpen))
        .Subscribe(_=>{
            gameObject.SetActive(true);
            transform.DOMove(Vector3.zero,1);
            transform.DORotate(Vector3.zero,1);
            transform.DOScale(Vector3.one,1);
            Observable.EveryUpdate()
            .Where(y=>(Input.GetMouseButtonDown(0)))
            .First()
            .Subscribe(y_=>{
                transform.DOMove(new Vector3(7,5,0),1);
                transform.DORotate(Vector3.zero,1);
                transform.DOScale(Vector3.zero,1);
                SelectToolsName.Instance().selectToolOpen=false;
                Observable.Timer(TimeSpan.FromSeconds(0.8))
                .First()
                .Subscribe(setActive=>{
                    gameObject.SetActive(false);
                });
            });
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        GetComponent<BoxCollider2D>().enabled=false;
        transform.DOMove(new Vector3(0,0,0),1);
        transform.DORotate(Vector3.zero,1);
        //设置图层
        SpriteRenderer keySpriteRenderer=GetComponent<SpriteRenderer>();
        keySpriteRenderer.sortingOrder=31;
        //提示字幕  打开UIMessage
        UIKit.ShowPanel<UIMessagePanel>();
        UIKit.GetPanel<UIMessagePanel>().text.Value="一张信纸";

         Observable.EveryUpdate()
        .Where(_=>((transform.position==Vector3.zero)))
        .Delay(TimeSpan.FromSeconds(0.5))
        .First()
        .Subscribe(_=>{
            transform.DOMove(new Vector3(7,5,0),1);
            transform.DORotate(Vector3.zero,1);
            transform.DOScale(Vector3.zero,1);

            Observable.Timer(TimeSpan.FromSeconds(1))
            .First()
            .Subscribe(setActive=>{
                gameObject.SetActive(false);
                //把信纸放到UITools
                UIKit.GetPanel<UIToolsPanel>().collection.Add("paper");
            });
        });
    }
}
