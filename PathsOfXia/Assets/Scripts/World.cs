using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {

    public List<InnerMartialArt> allInnerMartialArts;
    public List<OuterMartialArt> allOuterMartialArts;

    public Dictionary<int, InnerMartialArt> mapIMA;
    public Dictionary<int, OuterMartialArt> mapOMA;


    // Use this for initialization
    void Start () {
		
	}

    void Awake()
    {
        loadAllInnerMartialArts();

        loadAllOuterMartialArts();

    }

    // Update is called once per frame
    void Update () {
		
	}

    void loadAllInnerMartialArts()
    {
        mapIMA = new Dictionary<int, InnerMartialArt>
        {
            {0, new InnerMartialArt()},
            {1, new InnerMartialArt(1, "坐忘功", "流传与江湖的入门内功。", 15, 15 )}
        };
    }

    void loadAllOuterMartialArts()
    {
        mapOMA = new Dictionary<int, OuterMartialArt>
        {
            {0, new OuterMartialArt()},
            {1, new OuterMartialArt(1, "越女剑法", "灵动矫健，以柔克刚的剑法。", 1, 1.5f, 0.5f )},
            {2, new OuterMartialArt{id = 2, name = "旋风腿法", description="", weapon = 2, yinMultiplier=1.2f, yangMultiplier=0.8f}}
        };
    }
}
