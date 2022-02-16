using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using QFramework.Example;

public class ReskitLoads : MonoBehaviour
{
    private void Awake() {
         ResMgr.Init ();
    }
    // Start is called before the first frame update

    ResLoader mResLoader = ResLoader.Allocate();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy()
        {
            // 释放所有本脚本加载过的资源
            // 释放只是释放资源的引用
            // 当资源的引用数量为 0 时，会进行真正的资源卸载操作
            mResLoader.Recycle2Cache();
            mResLoader = null;
        }

    
}
