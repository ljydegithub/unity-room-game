using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenes
{
    private static Scenes instance = null;
    

    private Scenes() { }

    public static Scenes Instance()
    {
          if (instance == null)
            {
                instance = new Scenes();
            }
        return instance;
    }
    public Dictionary<string,GameObject> scene=new Dictionary<string, GameObject>();
}
