using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiScoreSaver : MonoBehaviour
{
    public static HiScoreSaver Instance;

    public static string playerName;
    public static string hiScoreText;
    public static string hiScoreName = "Player 1";

    public static int hiScore = 0;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
