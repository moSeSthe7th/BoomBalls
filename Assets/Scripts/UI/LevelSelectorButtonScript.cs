using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectorButtonScript : MonoBehaviour
{
    private Text levelNoText;
    private int levelNo;
    

    public void OpenLevelWithNumber()
    {
        levelNoText = GetComponentInChildren<Text>();
        int.TryParse(levelNoText.text,out levelNo);
        DataScript.currentLevel = levelNo;
        PlayerPrefs.SetInt("Current Level", levelNo);

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
