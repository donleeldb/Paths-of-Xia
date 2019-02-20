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
        using (StreamWriter streamWriter = File.CreateText(dataPath))
        {
            streamWriter.Write(jsonString);
        }
    }

    public void LoadGame()
    {
        using (StreamReader streamReader = File.OpenText(dataPath))
        {
            string jsonString = streamReader.ReadToEnd();
            player.GetComponent<Player>().loadCharacter(jsonString);
        }
    }
}
