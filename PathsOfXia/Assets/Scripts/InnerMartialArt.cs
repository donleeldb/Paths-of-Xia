using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerMartialArt : MonoBehaviour {

    public int id;
    public string name;
    public string description;
    public float yinBase;
    public float yangBase;

    public InnerMartialArt()
    {
        id = 0;
        name = "吐纳功";
        description = "基本呼吸吐纳法，修炼后能够强身健体。";
        yinBase = 10;
        yangBase = 10;
    }

    public InnerMartialArt(int i, string n, string d, float yinb, float yangb)
    {
        id = i;
        name = n;
        description = d;
        yinBase = yinb;
        yangBase = yangb;
    }
}
