using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public TextAsset sitesInput;
    public TextAsset sitesRoutesInput;

    //public List<InnerMartialArt> allInnerMartialArts;
    //public List<OuterMartialArt> allOuterMartialArts;

    //public Dictionary<int, InnerMartialArt> mapIMA;
    //public Dictionary<int, OuterMartialArt> mapOMA;

    public Dictionary<int, string> sites;
    public Dictionary<int, List<int>> sitesRoutes;

    //public string sitesFilePath = "";
    //public string worldMapFilePath = "";
    // Use this for initialization
    void Start()
    {
        //LoadWorldMap();
    }

    void Awake()
    {
        //loadAllInnerMartialArts();
        //loadAllOuterMartialArts();
        LoadWorldMap();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //void loadAllInnerMartialArts()
    //{
    //    mapIMA = new Dictionary<int, InnerMartialArt>
    //    {
    //        {0, new InnerMartialArt()},
    //        {1, new InnerMartialArt(1, "坐忘功")}
    //    };
    //}

    //void loadAllOuterMartialArts()
    //{
    //    mapOMA = new Dictionary<int, OuterMartialArt>
    //    {
    //        {0, new OuterMartialArt()},
    //        {1, new OuterMartialArt(1, "越女剑法")},
    //        {2, new OuterMartialArt(2, "旋风腿法")}
    //    };
    //}

    public void LoadWorldMap()
    {
        sites = new Dictionary<int, string>();
        string[] siteNames = sitesInput.text.Split('\n');
        for (int i = 0; i < siteNames.Length; i++)
        {
            sites.Add(i, siteNames[i]);
        }
        sitesRoutes = new Dictionary<int, List<int>>();
        string[] sitesConnections = sitesRoutesInput.text.Split('\n');
        //Debug.Log(sitesConnections.Length);
        for (int i = 0; i < sitesConnections.Length; i++)
        {
            sitesRoutes.Add(i, new List<int>());
            if (sitesConnections[i].Equals(""))
            {
                continue;
            }
            string[] neighbors = sitesConnections[i].Split('\t');

            foreach (string neighor in neighbors)
            {
                sitesRoutes[i].Add(int.Parse(neighor));
                //Debug.Log("path to " + neighor + " is added to ritesRouts of" + i);
            }
        }
    }
}
