using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using QFramework.Example;
public class StartGame : MonoBehaviour
{

    private void Awake() {
        ResKit.Init();
    }
    // Start is called before the first frame update

    ResLoader mResLoader = ResLoader.Allocate();
    void Start()
    {
        // // 加载一个列表中的资源
        // mResLoader.Add2Load(new List<string>(){ "sceneone"});
        // // 执行加载操作
        // mResLoader.LoadAsync(()=>{
        // // 可以监听所有的资源是否加载成功
        // "资源加载成功".LogInfo();
        // });
        
        AudioKit.PlayMusic("bgm");
        UIKit.OpenPanel<UIHomePanel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy() {
        // 释放所有本脚本加载过的资源
        // 释放只是释放资源的引用
        // 当资源的引用数量为 0 时，会进行真正的资源卸载操作
        mResLoader.Recycle2Cache();
        mResLoader = null;
    }
}
