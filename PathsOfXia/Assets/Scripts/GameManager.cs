using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;

    [SerializeField] private GameObject player;

    string dataPath;

    // Use this for initialization
    void Start () {
        dataPath = Path.Combine(Application.persistentDataPath, "CharacterData.txt");
        //Debug.Log("Text: " + dataPath);
        if (File.Exists(dataPath))
        {
            LoadGame();
        }
    }

    // Use this for awake
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void SaveGame() {
        string jsonString = JsonUtility.ToJson(player.GetComponent<Player>().GetPlayerInfo());
        Debug.Log(jsonString);
        //string jsonStringIMA = JsonUtility.ToJson(player.GetComponent<Player>().GetPlayerInfo().IMALevel);
        //Debug.Log(jsonStringIMA);
        //Debug.Log(player.GetComponent<Player>().GetPlayerInfo().IMALevel);
        //string jsonStringOMA = JsonUtility.ToJson(player.GetComponent<Player>().GetPlayerInfo().OMALevel);
        using (StreamWriter streamWriter = File.CreateText(dataPath))
        {
            streamWriter.WriteLine(jsonString);
            //streamWriter.WriteLine();
            //streamWriter.WriteLine(jsonStringIMA);
            //streamWriter.WriteLine();
            //streamWriter.WriteLine(jsonStringOMA);
        }
    }

    public void LoadGame()
    {
        using (StreamReader streamReader = File.OpenText(dataPath))
        {
            string jsonString = streamReader.ReadLine();
            player.GetComponent<Player>().loadCharacter(jsonString);

            //string jsonStringIMA = streamReader.ReadLine();
            //player.GetComponent<Player>().GetPlayerInfo().IMALevel = JsonUtility.FromJson<Dictionary<int,int>>(jsonStringIMA);

            //string jsonStringOMA = streamReader.ReadLine();
            //player.GetComponent<Player>().GetPlayerInfo().OMALevel = JsonUtility.FromJson<Dictionary<int, int>>(jsonStringOMA);
        }
    }
}
