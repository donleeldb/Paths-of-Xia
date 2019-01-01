using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour {

    [SerializeField] private GameObject player;
    public Text AbilitiesText;
    public Text PlayerStateText;
    // Use this for initialization
    void Start () {
        GameObject.Find("TrainQingGong").GetComponentInChildren<Text>().text = "修炼轻功";
        GameObject.Find("TrainYingGong").GetComponentInChildren<Text>().text = "修炼硬功";
        GameObject.Find("TrainRuanGong").GetComponentInChildren<Text>().text = "修炼软功";
    }
	
	// Update is called once per frame
	void Update () {
        PlayerStateText.text = "角色正在" + player.gameObject.GetComponent<Player>().GetPlayerState();

        AbilitiesText.text = "角色能力\n";
        AbilitiesText.text += "轻功值：" + player.gameObject.GetComponent<Player>().GetQingGong() + "\n";
        AbilitiesText.text += "硬功值：" + player.gameObject.GetComponent<Player>().GetYingGong() + "\n";
        AbilitiesText.text += "软功值：" + player.gameObject.GetComponent<Player>().GetRuanGong() + "\n";
        AbilitiesText.text += "眼功值：" + player.gameObject.GetComponent<Player>().GetYanGong() + "\n";
        AbilitiesText.text += "耳功值：" + player.gameObject.GetComponent<Player>().GetErGong() + "\n";
        AbilitiesText.text += "内功值（阳）：" + player.gameObject.GetComponent<Player>().GetYangNeiGong() + "\n";
        AbilitiesText.text += "内功值（阴）：" + player.gameObject.GetComponent<Player>().GetYinNeiGong() + "\n";

    }

    public void TrainQingGong() {
        player.gameObject.GetComponent<Player>().TrainQingGong();
    }

    public void TrainYingGong() {
        player.gameObject.GetComponent<Player>().TrainYingGong();
    }

    public void TrainRuanGong() {
        player.gameObject.GetComponent<Player>().TrainRuanGong();
    }
}
