using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

public class SelectToolsName
{
    private static SelectToolsName instance = null;
    

    private SelectToolsName() { }
    //定义现在选择的工具名是什么
    public string selectToolName{
        get;set;
    }
    //定义一个开关用来查看工具
    public bool selectToolOpen{
        get;set;
    }

    public static SelectToolsName Instance()
    {
          if (instance == null)
            {
                instance = new SelectToolsName();
            }
        return instance;
    }
}
