using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private PlayerInfo playerInfo;

    // Use this for initialization
    void Start () {
        playerInfo = new PlayerInfo();
    }
	
	// Update is called once per frame
	void Update () {

    }

    // Trainings 
    public void TrainQingGong() {
        playerInfo.playerStatus = "TrainingQingGong";
        playerInfo.QingGong += 1;
    }
    public void TrainYingGong() {
        playerInfo.playerStatus = "TrainingYingGong";
        playerInfo.YingGong += 1;
    }
    public void TrainRuanGong() {
        playerInfo.playerStatus = "TrainingRuanGong";
        playerInfo.RuanGong += 1;
    }
    public void TrainYanGong() {
        playerInfo.playerStatus = "TrainingYanGong";
        playerInfo.YanGong += 1;
    }
    public void TrainErGong() {
        playerInfo.playerStatus = "TrainingErGong";
    }

    // playerState getter
    public string GetPlayerState() {
        return playerInfo.playerState;
    }

    // playerStatus getter
    public string GetPlaerStatus() {
        return playerInfo.playerStatus;
    }

    // Abilities Getters
    public float GetQingGong() {
        return playerInfo.QingGong;
    }
    public float GetYingGong(){
        return playerInfo.YingGong;
    }
    public float GetRuanGong(){
        return playerInfo.RuanGong;
    }
    public float GetYanGong(){
        return playerInfo.YanGong;
    }
    public float GetErGong(){
        return playerInfo.ErGong;
    }
    public float GetYangNeiGong(){
        return playerInfo.NeiGongYang;
    }
    public float GetYinNeiGong(){
        return playerInfo.NeiGongYin;
    }


    public PlayerInfo GetPlayerInfo() {
        return playerInfo;
    }
    public void loadCharacter(string jsonString ) {
        playerInfo = PlayerInfo.CreateFromJSON(jsonString);
    }
}
