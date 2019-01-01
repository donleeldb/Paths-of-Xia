using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    [SerializeField] private float QingGong = 1f;
    [SerializeField] private float YingGong = 1f;
    [SerializeField] private float RuanGong = 1f;
    [SerializeField] private float YanGong = 1f;
    [SerializeField] private float ErGong = 1f;
    [SerializeField] private float NeiGongYang = 1f;
    [SerializeField] private float NeiGongYin = 1f;

    private string playerState;
    private string playerStatus;


    // Use this for initialization
    void Start () {
        //playerState = "Home";
        //playerStateText.text = "started";
    }
	
	// Update is called once per frame
	void Update () {
        //playerQingGongText.text = "轻功值：" + QingGong + "\n";
        //playerQingGongText.text = "硬功值：" + YingGong + "\n";
        //playerQingGongText.text = "软功值：" + RuanGong + "\n";
        //playerQingGongText.text = "眼功值：" + YanGong + "\n";
        //playerQingGongText.text = "耳功值：" + ErGong + "\n";
        //playerQingGongText.text = "阳内功值：" + NeiGongYang + "\n";
        //playerQingGongText.text = "阴内功值：" + NeiGongYin + "\n";
    }

    // Trainings 
    public void TrainQingGong() {
        playerState = "TrainingQingGong";
    }
    public void TrainYingGong() {
        playerState = "TrainingYingGong";
    }
    public void TrainRuanGong() {
        playerState = "TrainingRuanGong";
    }
    public void TrainYanGong() {
        playerState = "TrainingYanGong";
    }
    public void TrainErGong() {
        playerState = "TrainingErGong";
    }

    // Get Player's state
    public string GetPlayerState() {
        return playerState;
    }

    // AbilitiesGetters
    public float GetQingGong() {
        return QingGong;
    }
    public float GetYingGong()
    {
        return YingGong;
    }
    public float GetRuanGong()
    {
        return RuanGong;
    }
    public float GetYanGong()
    {
        return YanGong;
    }
    public float GetErGong()
    {
        return ErGong;
    }
    public float GetYangNeiGong()
    {
        return NeiGongYang;
    }
    public float GetYinNeiGong()
    {
        return NeiGongYin;
    }
}
