using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private PlayerInfo playerInfo;

    // Use this for initialization
    private void Start()
    {

    }

    private void Awake()
    {
        playerInfo = new PlayerInfo();
    }

    // Update is called once per frame
    void Update () {

        //playerInfo.yingGong = playerInfo.arriveTime.Second;

        if (playerInfo.isAway)
        {

            DateTime currTime = DateTime.Now;
            if (currTime.CompareTo(DateTime.Parse(playerInfo.arriveTime)) > 0)
            {
                playerInfo.isAway = false;
                playerInfo.isAtDoor = true;
                playerInfo.arriveTime = "";
            }
        } else
        {
            //playerInfo.isAtDoor = true;
        }

        if (playerInfo.isAtDoor)
        {
            playerInfo.isHome = true;
            playerInfo.isAtDoor = false;
            playerInfo.isAway = false;
            playerInfo.OMALevel[2] += 10;
        }


    }

    // Trainings 
    public void TrainQingGong() {
        //switchState("Train", "QingGong");
    }
    public void TrainYingGong() {
        //switchState("Train", "YingGong");
    }
    public void TrainRuanGong() {
        //switchState("Train", "RuanGong");
    }
    public void TrainYanGong() {
        //switchState("Train", "YanGong");
    }
    public void TrainErGong() {
        //switchState("Train", "ErGong");
    }

    // playerState getter
    public string GetPlayerState() {
        return playerInfo.arriveTime;
    }

    // playerStatus getter
    public string GetPlayerStatus() {
        return playerInfo.playerStatus;
    }

    public PlayerInfo GetPlayerInfo() {
        return playerInfo;
    }

    public void loadCharacter(string jsonString ) {
        playerInfo = PlayerInfo.CreateFromJSON(jsonString);
    }

    public void Travel() {
        if (playerInfo.isHome) {
            playerInfo.arriveTime = DateTime.Now.AddSeconds(20).ToString();
            playerInfo.isHome = false;
            playerInfo.isAway = true;
        }
    }

    public void Return() {

    }

}
