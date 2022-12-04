using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class MenuManager : MonoBehaviour
{   
   /*  private SceneManager sceneManager; */

    public TextMeshProUGUI HiScoreText;
    public InputField playerNameInputField;

    // Start is called before the first frame update
    void Start()
    {
        LoadHiScore();
        HiScoreText.text = $"Hi-Score : {HiScoreSaver.hiScoreName} + {HiScoreSaver.hiScore}";
        
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (playerNameInputField.text != HiScoreSaver.hiScoreName)
        {
            HiScoreSaver.playerName = playerNameInputField.text;
            /* Debug.Log("New Player Name!"); */
        }
    }

    public void loadMainScene()
    {
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }

    [System.Serializable]
    class SaveData
    {
        public string hiScoreName;
        public int hiScore;
    }


    public void LoadHiScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HiScoreSaver.hiScoreName = data.hiScoreName;
            HiScoreSaver.hiScore = data.hiScore;
        }
    }
}
