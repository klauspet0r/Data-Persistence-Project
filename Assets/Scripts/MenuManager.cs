using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{   
   /*  private SceneManager sceneManager; */

    public TextMeshProUGUI HiScoreText;
    public InputField playerNameInputField;

    // Start is called before the first frame update
    void Start()
    {
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
}
