using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using System.Web.Script.Serialization;

[System.Serializable]
public class PlayerInfo {

    public string name;

    public float bank;

    public float qingGong;                  // 基本功
    public float yingGong;
    public float ruanGong;
    public float yanGong;
    public float erGong;
    public float neiGongYang;
    public float neiGongYin;                

    public string playerState;              // home, away
    public string playerStatus;             // training, cooking, black smithing, etc

    public bool isAway;
    public bool isHome;
    public bool isAtDoor;

    public string arriveTime;

    public float reputation;                // 江湖值
    public float morality;

    public float musicStat;                 // 音韵
    public float chessStat;                 // 棋艺
    public float caligrStat;                  // 书法
    public float paintStat;                 // 丹青

    public float cookingStat;               // 烹饪
    public float smithingStat;              // 锻造
    public float alchemyStat;               // 炼丹
    public float huntingStat;               // 打猎
    public float miningStat;                // 挖矿
    public float herbalismStat;             // 采药
    public float teaStat;                   // 茶道
    public float healingStat;               // 医术
    public float poisonStat;                // 毒术
    public float elementalStat;              // 五行
    public float eightHexagramStat;         // 八卦

    public HashSet<string> neiGongXinFas;   // 武学: 内功心法
    public HashSet<string> wuXueTaoLus;     // 武学: 武学套路

    public List<int> learnedIMA;
    public List<int> learnedOMA;

    public Dictionary<int, int> IMALevel;
    public Dictionary<int, int> OMALevel;

    public PlayerInfo() {
        this.playerState = "家";
        this.playerStatus = "";

        this.isHome = true;
        this.isAway = false;
        this.isAtDoor = false;

        this.qingGong = 1f;
        this.yingGong = 1f;
        this.ruanGong = 1f;
        this.yanGong = 1f;
        this.erGong = 1f;
        this.neiGongYang = 1f;
        this.neiGongYin = 1f;

        this.reputation = 1f;
        this.morality = 1f;

        this.musicStat = 1f;
        this.chessStat = 1f;
        this.caligrStat = 1f;
        this.paintStat = 1f;

        this.cookingStat = 1f;
        this.smithingStat = 1f;
        this.alchemyStat = 1f;
        this.huntingStat = 1f;
        this.miningStat = 1f;
        this.herbalismStat = 1f;
        this.teaStat = 1f;
        this.healingStat = 1f;
        this.poisonStat = 1f;
        this.elementalStat = 1f;
        this.eightHexagramStat = 1f;

        this.neiGongXinFas = new HashSet<string>();
        this.wuXueTaoLus = new HashSet<string>();

        //this.learnedIMA = new List<int> { 1 };
        //this.learnedOMA = new List<int> { 0, 2 };

        this.IMALevel = new Dictionary<int, int>
        {
            {0, 100},
            {1, 100}
        };
        this.OMALevel = new Dictionary<int, int>
        {
            {0, 100},
            {1, 100},
            {2, 100}
        };

    }

    public static PlayerInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PlayerInfo>(jsonString);
    }
}
