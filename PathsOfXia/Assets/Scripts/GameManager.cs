using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public GameObject enterHomeWindow;
    public GameObject worldMapWindow;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject world;
    [SerializeField] private GameObject ui;
    private bool playerActive = true;

    string dataPath;

    public bool PlayerActive
    {
        get { return playerActive; }
    }

    // Use this for initialization
    void Start () {
        dataPath = Path.Combine(Application.persistentDataPath, "CharacterData.txt");
        Debug.Log("Text: " + dataPath);
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
        //player.SetActive(false);

    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void StartGame()
    {
        if (File.Exists(dataPath))
        {
            LoadGame();
            Debug.Log("LoadGame() function called");
        }
        player.SetActive(true);
        playerActive = true;
    }

    public void SaveGame() {
        string jsonString = JsonUtility.ToJson(player.GetComponent<Player>().GetPlayerInfo());

        using (StreamWriter streamWriter = File.CreateText(dataPath))
        {
            streamWriter.WriteLine(jsonString);
        }
    }

    public void LoadGame()
    {
        if (playerActive)
        {
            using (StreamReader streamReader = File.OpenText(dataPath))
            {
                string jsonString = streamReader.ReadLine();
                player.GetComponent<Player>().LoadCharacter(jsonString);

            }
        }

    }

    public void OpenEnterHomeWindow()
    {
        enterHomeWindow.SetActive(true);
    }

    public void CloseEnterHomeWindow()
    {
        enterHomeWindow.SetActive(false);
        player.GetComponent<Player>().FinishEnterHome();
    }

    public void OpenMapWindow()
    {
        worldMapWindow.SetActive(true);
    }

    public void CloseMapWindow()
    {
        worldMapWindow.SetActive(false);
    }
}
