using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PianoKeyList
{
    private static PianoKeyList instance = null;
    

    private PianoKeyList() { }

    
    public static PianoKeyList Instance()
    {
          if (instance == null)
            {
                instance = new PianoKeyList();
            }
        return instance;
    }
}
