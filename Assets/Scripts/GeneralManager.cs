using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GeneralManager : MonoBehaviour
{

    public static GeneralManager Instance;

    public string playerName;
    public string currentName;
    public int highScore;
    public GameObject mainManager;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHS();
    }


   

    [System.Serializable]

    class SaveData
    {
        public string playerName;
        public int highScore;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveHS()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log(playerName);
        Debug.Log(highScore);

    }

    public void LoadHS()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            highScore = data.highScore;
            Debug.Log(path);
        }
    }






}
