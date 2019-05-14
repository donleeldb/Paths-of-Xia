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
            {1, new InnerMartialArt(1, "坐忘功")}
        };
    }

    void loadAllOuterMartialArts()
    {
        mapOMA = new Dictionary<int, OuterMartialArt>
        {
            {0, new OuterMartialArt()},
            {1, new OuterMartialArt(1, "越女剑法")},
            {2, new OuterMartialArt(2, "旋风腿法")}
        };
    }
}
