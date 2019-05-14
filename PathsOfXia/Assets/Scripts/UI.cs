using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour {

    [SerializeField] private GameObject player;
    private Player playerInstance;
    private World worldInstance;

    //public GameManager gameManager;
    public Text AbilitiesText;
    public Text PlayerStateText;
    //public Text PlayerStatusText;

    // Use this for initialization
    void Start () {
        playerInstance = player.gameObject.GetComponent<Player>();
        worldInstance = player.gameObject.GetComponent<World>();

        GameObject.Find("TrainQingGong").GetComponentInChildren<Text>().text = "修炼轻功";
        GameObject.Find("TrainYingGong").GetComponentInChildren<Text>().text = "修炼硬功";
        GameObject.Find("TrainRuanGong").GetComponentInChildren<Text>().text = "修炼软功";
        GameObject.Find("Save Game").GetComponentInChildren<Text>().text = "保存游戏";
        GameObject.Find("Load Game").GetComponentInChildren<Text>().text = "读取存档";
        GameObject.Find("Travel").GetComponentInChildren<Text>().text = "出行";
    }
	
	// Update is called once per frame
	void Update () {
        PlayerStateText.text = "角色isHome:" + playerInstance.GetPlayerInfo().isHome + "\n";
        PlayerStateText.text += "角色isAway:" + playerInstance.GetPlayerInfo().isAway + "\n";

        PlayerStateText.text += "角色isAtDoor:" + playerInstance.GetPlayerInfo().isAtDoor + "\n";
        PlayerStateText.text += "角色回家时间:" + playerInstance.GetPlayerInfo().arriveTime + "\n";

        //AbilitiesText.text = "角色能力\n";
        //AbilitiesText.text += "轻功值：" + playerInstance.GetPlayerInfo().qingGong + "\n";
        //AbilitiesText.text += "硬功值：" + playerInstance.GetPlayerInfo().yingGong + "\n";
        //AbilitiesText.text += "软功值：" + playerInstance.GetPlayerInfo().ruanGong + "\n";
        //AbilitiesText.text += "眼功值：" + playerInstance.GetPlayerInfo().yanGong + "\n";
        //AbilitiesText.text += "耳功值：" + playerInstance.GetPlayerInfo().erGong + "\n";
        //AbilitiesText.text += "内功值（阳）：" + playerInstance.GetPlayerInfo().neiGongYang + "\n";
        //AbilitiesText.text += "内功值（阴）：" + playerInstance.GetPlayerInfo().neiGongYin + "\n";


        AbilitiesText.text = "角色现在会的内功有： ";
        int[] knownIMA = playerInstance.GetPlayerInfo().testArray;
        AbilitiesText.text += knownIMA.Length;
        int i = 0;
        foreach (int level in knownIMA)
        {
            // do something with entry.Value or entry.Key
            AbilitiesText.text += worldInstance.mapIMA[i].name;
            AbilitiesText.text += " 目前修为是： ";
            AbilitiesText.text += knownIMA[i];
            AbilitiesText.text += "\n";
            i++;
        }

        //AbilitiesText.text += "角色现在会的武功有： ";
        //int[] knownOMA = playerInstance.GetPlayerInfo().OMALevel;
        //AbilitiesText.text += knownOMA.Count;
        //foreach (KeyValuePair<int, int> entry in knownOMA)
        //{
        //    // do something with entry.Value or entry.Key
        //    AbilitiesText.text += worldInstance.mapOMA[entry.Key].name;
        //    AbilitiesText.text += " 目前修为是： ";
        //    AbilitiesText.text += entry.Value;
        //    AbilitiesText.text += "\n";
        //}
        //List<int> knownOMA = playerInstance.GetPlayerInfo().learnedOMA;
        //for (int id = 0; id < knownOMA.Count; id++)
        //{
        //    if (worldInstance.mapOMA.ContainsKey(id))
        //    {
        //        AbilitiesText.text += worldInstance.mapOMA[id].name;
        //        AbilitiesText.text += "\n";
        //    }
        //}


    }

    public void TrainQingGong() {
        playerInstance.TrainQingGong();
    }

    public void TrainYingGong() {
        playerInstance.TrainYingGong();
    }

    public void TrainRuanGong() {
        playerInstance.TrainRuanGong();
    }

    public void SaveGame() {
        GameManager.instance.SaveGame();
    }

    public void LoadGame() {
        GameManager.instance.LoadGame();
    }

    public void Travel() {
        playerInstance.Travel();
    }
}
