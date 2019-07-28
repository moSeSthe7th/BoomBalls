using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButtonScript : MonoBehaviour
{
    public void StartNextLevel()
    {
        if (DataScript.currentLevel < DataScript.totalLevelCount)
        {
            DataScript.currentLevel = DataScript.currentLevel + 1;
            PlayerPrefs.SetInt("Current Level", DataScript.currentLevel);
        }
        
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
}
