using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using System.Web.Script.Serialization;

[System.Serializable]
public class PlayerInfo {

    public string name;

    public float bank;

    //public float qingGong;                  // 基本功
    //public float yingGong;
    //public float ruanGong;
    //public float yanGong;
    //public float erGong;
    //public float neiGongYang;
    //public float neiGongYin;                

    //public string playerState;              // home, away
    //public string playerStatus;             // training, cooking, black smithing, etc

    public bool isAway;
    public bool isHome;
    public bool isAtDoor;

    public string arriveTime;

    //public float reputation;                // 江湖值
    //public float morality;

    //public float musicStat;                 // 音韵
    //public float chessStat;                 // 棋艺
    //public float caligrStat;                  // 书法
    //public float paintStat;                 // 丹青

    //public float cookingStat;               // 烹饪
    //public float smithingStat;              // 锻造
    //public float alchemyStat;               // 炼丹
    //public float huntingStat;               // 打猎
    //public float miningStat;                // 挖矿
    //public float herbalismStat;             // 采药
    //public float teaStat;                   // 茶道
    //public float healingStat;               // 医术
    //public float poisonStat;                // 毒术
    //public float elementalStat;              // 五行
    //public float eightHexagramStat;         // 八卦

    public int[] visited;

    //public HashSet<string> neiGongXinFas;   // 武学: 内功心法
    //public HashSet<string> wuXueTaoLus;     // 武学: 武学套路

    //public List<int> learnedIMA;
    //public List<int> learnedOMA;

    //public Dictionary<int, int> IMALevel;
    //public Dictionary<int, int> OMALevel;

    public PlayerInfo() {
        //this.playerState = "家";
        //this.playerStatus = "";
        this.name = "谷雨";
        this.bank = 0f;

        this.isHome = true;
        this.isAway = false;
        this.isAtDoor = false;
        this.visited = new int[72];
    }

    public static PlayerInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PlayerInfo>(jsonString);
    }
}
