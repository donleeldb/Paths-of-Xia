using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour {
    [SerializeField] private GameObject enterHomeWindow;
    [SerializeField] private GameObject world;

    [SerializeField] private Text TravelPathText;
    [SerializeField] private Text AbilitiesText;
    [SerializeField] private Text PlayerStateText;
    [SerializeField] private Text BankText;

    private PlayerInfo playerInfo;
    private Text playerReturnText;
    private World worldInstance;

    private void Awake()
    {
        worldInstance = world.gameObject.GetComponent<World>();
    }

    // Use this for initialization
    private void Start()
    {
        playerInfo = new PlayerInfo();
    }


    // Update is called once per frame
    void Update () {
        if (GameManager.instance.PlayerActive)
        {

            PlayerStateText.text = "角色isHome:" + playerInfo.isHome + "\n";
            PlayerStateText.text += "角色isAway:" + playerInfo.isAway + "\n";
            PlayerStateText.text += "角色isAtDoor:" + playerInfo.isAtDoor + "\n";
            PlayerStateText.text += "角色回家时间:" + playerInfo.arriveTime + "\n";

            BankText.text = "角色拥有的钱： " + playerInfo.bank + "\n";

            if (playerInfo.isAway && !playerInfo.arriveTime.Equals(""))
            {
                DateTime currTime = DateTime.Now;
                if (currTime.CompareTo(DateTime.Parse(playerInfo.arriveTime)) > 0)
                {
                    playerInfo.isAway = false;
                    playerInfo.isAtDoor = true;
                    playerInfo.arriveTime = "";
                }
            }
            else
            {
                //playerInfo.isAtDoor = true;
            }

            if (playerInfo.isAtDoor)
            {
                EnterHome();
            }
        }


    }
    public Boolean isAway()
    {
        return playerInfo.isAway;
    }


    // playerState getter
    public string GetPlayerState() {
        return playerInfo.arriveTime;
    }

    public PlayerInfo GetPlayerInfo() {
        return playerInfo;
    }

    public void LoadCharacter(string jsonString ) {
        playerInfo = PlayerInfo.CreateFromJSON(jsonString);
        Debug.Log("character loaded");
        Debug.Log(playerInfo.name);
    }

    public void Travel() {
        if (playerInfo.isHome) {
            playerInfo.arriveTime = DateTime.Now.AddSeconds(3).ToString();
            playerInfo.isHome = false;
            playerInfo.isAway = true;
        }
    }

    public void EnterHome()
    {
        if (!GameManager.instance.PlayerActive)
        {
            return;
        }
        //TravelPathText.text = "" + worldInstance.sitesRoutes[0][0];

        playerInfo.isAtDoor = false;
        int currSite = 0;
        bool finishTravel = false;
        TravelPathText.text = playerInfo.name + "从家出发\n";
        while (!finishTravel)
        {
            //Debug.Log(finishTravel);
            //Debug.Log("we are now at "+worldInstance.sites[currSite]);

            List<int> dests = worldInstance.sitesRoutes[currSite];
            int n = dests.Count;

            //Debug.Log("we have " + n + " available dests");
            if (n == 0)
            {
                finishTravel = true;
                //Debug.Log("break is called");
                break;
            }
            int dest = Random.Range(0, n);
            TravelPathText.text += "经过了 " + worldInstance.sites[currSite] + "\n";
            //Debug.Log(" we choose to go to the " + dest + " of them");
            currSite = dests[dest];

            int done = Random.Range(0, 5);
            if (done==1)
            {
                finishTravel = true;
            }
        }
        TravelPathText.text += "最远去到了 " + worldInstance.sites[currSite] + " \n";



        GameManager.instance.OpenEnterHomeWindow();
        //FinishEnterHome();
    }

    public void FinishEnterHome()
    {
        playerInfo.isAtDoor = false;
        playerInfo.isAway = false;
        playerInfo.isHome = true;
    }

}
