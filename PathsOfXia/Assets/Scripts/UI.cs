using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour {

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject world;
    private Player playerInstance;
    private World worldInstance;

    //public GameManager gameManager;
    public Text AbilitiesText;
    public Text PlayerStateText;
    public Text BankText;
    public Text TravelText;

    // Use this for initialization
    void Start () {
        //playerInstance = player.gameObject.GetComponent<Player>();
        //worldInstance = world.gameObject.GetComponent<World>();
    }
	
	// Update is called once per frame
	void Update () {
        //PlayerStateText.text = "角色isHome:" + playerInstance.GetPlayerInfo().isHome + "\n";
        //PlayerStateText.text += "角色isAway:" + playerInstance.GetPlayerInfo().isAway + "\n";

        //PlayerStateText.text += "角色isAtDoor:" + playerInstance.GetPlayerInfo().isAtDoor + "\n";
        //PlayerStateText.text += "角色回家时间:" + playerInstance.GetPlayerInfo().arriveTime + "\n";

        //AbilitiesText.text = "角色现在会的内功有：";

        //BankText.text = "角色拥有的钱： " + playerInstance.GetPlayerInfo().bank + "\n";
    }

}
