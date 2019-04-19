using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterMartialArt : MonoBehaviour
{

    public int id;
    public string name;
    public string description;
    public int weapon;
    public float yinMultiplier;
    public float yangMultiplier;

    public OuterMartialArt()
    {
        id = 0;
        name = "南山拳";
        description = "相传是由南方地区的人民为了抵御山贼威胁而创。而后因其简单易学而传遍中原。拳风朴实，威力有限。";
        weapon = 0;
        yinMultiplier = 1;
        yangMultiplier = 1;
    }

    public OuterMartialArt(int i, string n, string d, int w, float yinm, float yangm)
    {
        id = i;
        name = n;
        description = d;
        weapon = w;
        yinMultiplier = yinm;
        yangMultiplier = yangm;
    }
}
