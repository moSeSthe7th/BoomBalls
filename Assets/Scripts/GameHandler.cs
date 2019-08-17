using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    
    private void Awake()
    {
        DataScript.finishedBoxCount = 0;
        DataScript.boxCountInLevel = 0;
        DataScript.totalLevelCount = 26;
        DataScript.currentLevel = PlayerPrefs.GetInt("Current Level", 1);
        DataScript.maxReachedLevel = PlayerPrefs.GetInt("Max Reached Level", 1);
        DataScript.isGamePaused = false;
        DataScript.gameOverLock = true;
        DataScript.isBonusLevel = false;
        
        Time.timeScale = 2.5f;
        
    }

   

}
