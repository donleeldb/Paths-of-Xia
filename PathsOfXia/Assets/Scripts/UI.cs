using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour {

    [SerializeField] private GameObject player;
    private Player playerInstance;

    //public GameManager gameManager;
    public Text AbilitiesText;
    public Text PlayerStateText;

    // Use this for initialization
    void Start () {
        playerInstance = player.gameObject.GetComponent<Player>();

        GameObject.Find("TrainQingGong").GetComponentInChildren<Text>().text = "修炼轻功";
        GameObject.Find("TrainYingGong").GetComponentInChildren<Text>().text = "修炼硬功";
        GameObject.Find("TrainRuanGong").GetComponentInChildren<Text>().text = "修炼软功";
        GameObject.Find("Save Game").GetComponentInChildren<Text>().text = "保存游戏";
        GameObject.Find("Load Game").GetComponentInChildren<Text>().text = "读取存档";
    }
	
	// Update is called once per frame
	void Update () {
        PlayerStateText.text = "角色正在" + playerInstance.GetPlayerState();

        AbilitiesText.text = "角色能力\n";
        AbilitiesText.text += "轻功值：" + playerInstance.GetQingGong() + "\n";
        AbilitiesText.text += "硬功值：" + playerInstance.GetYingGong() + "\n";
        AbilitiesText.text += "软功值：" + playerInstance.GetRuanGong() + "\n";
        AbilitiesText.text += "眼功值：" + playerInstance.GetYanGong() + "\n";
        AbilitiesText.text += "耳功值：" + playerInstance.GetErGong() + "\n";
        AbilitiesText.text += "内功值（阳）：" + playerInstance.GetYangNeiGong() + "\n";
        AbilitiesText.text += "内功值（阴）：" + playerInstance.GetYinNeiGong() + "\n";

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
}
