using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInfo {

    public float QingGong;
    public float YingGong;
    public float RuanGong;
    public float YanGong;
    public float ErGong;
    public float NeiGongYang;
    public float NeiGongYin;
    public string playerState;              // home, away
    public string playerStatus;
    public HashSet<string> NeiGongXinfas;

    public PlayerInfo() {
        playerState = "home";
        playerStatus = "";

        this.QingGong = 1f;
        this.YingGong = 1f;
        this.RuanGong = 1f;
        this.YanGong = 1f;
        this.ErGong = 1f;
        this.NeiGongYang = 1f;
        this.NeiGongYin = 1f;
        this.NeiGongXinfas = new HashSet<string>();
    }

    public static PlayerInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PlayerInfo>(jsonString);
    }
}
