using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;

public class UIScript : MonoBehaviour
{
    //To add new sprite, first add it to the public sprite arrays from the editor, then set it in InitializeUI method

    // Buttons for Sprite Arrays (Used Colors): 
    //  0: Settings
    //  1: Levels
    //  2: Sound On
    //  3: Sound Off
    //  4: Exit Button
    //  5: Epmty Circle
    //  6: Next Level
    //  7: Restart
    //  8: Levels Panel Background
    
    public Sprite[] redUI;
    public Sprite[] orangeUI;
    public Sprite[] yellowUI;
    public Sprite[] greenUI;
    public Sprite[] blueUI;
    public Sprite[] purpleUI;
    public Sprite[] pinkUI;

    public Button settingsButton;
    public Button levelSelectorButton;
    public Button voiceToggler;
    public Button exitButton;
    public Button nextLevelButton;
    public Button restartButton;
    public Button restartButtonInSettings;

    public Text startingText;
    public Text bonusLevelText;

    public Image ballCounterImage;
    
    private Sprite[] usedColors;

    public GameObject settingsPanel;
    public GameObject backgroundPanel;
    public GameObject levelsPanel;
    public GameObject levelAccomplishedPanel;
    public GameObject gameOverPanel;
    public GameObject sphereAndCounterPanel;


    private LevelsPanelScript levelsPanelScript;

    void Start()
    {
        levelsPanelScript = FindObjectOfType(typeof(LevelsPanelScript)) as LevelsPanelScript;
        
    }

    public void InitializeUI(string levelStyle)
    {
        switch (levelStyle)
        {
            case "Red":
                usedColors = redUI;
                break;
            case "Orange":
                usedColors = orangeUI;
                break;
            case "Yellow":
                usedColors = yellowUI;
                break;
            case "Green":
                usedColors = greenUI;
                break;
            case "Blue":
                usedColors = blueUI;
                break;
            case "Purple":
                usedColors = purpleUI;
                break;
            case "Pink":
                usedColors = pinkUI;
                break;
            default:
                usedColors = redUI;
                break;
        }
        
        settingsButton.GetComponent<Image>().sprite = usedColors[0];
        levelSelectorButton.GetComponent<Image>().sprite = usedColors[1];
        voiceToggler.GetComponent<Image>().sprite = usedColors[2];
        exitButton.GetComponent<Image>().sprite = usedColors[4];
        nextLevelButton.GetComponent<Image>().sprite = usedColors[6];
        restartButton.GetComponent<Image>().sprite = usedColors[7];
        restartButtonInSettings.GetComponent<Image>().sprite = usedColors[7];
        ballCounterImage.sprite = usedColors[5];
        levelsPanel.GetComponent<Image>().sprite = usedColors[8];

        settingsPanel.SetActive(false);
        backgroundPanel.SetActive(false);
        exitButton.gameObject.SetActive(false);
        levelsPanel.SetActive(false);
        levelAccomplishedPanel.SetActive(false);
        gameOverPanel.SetActive(false);

        if (!DataScript.isBonusLevel)
        {
            bonusLevelText.gameObject.SetActive(false);
        }

        levelsPanelScript.CreateLevelsPanelWithColor(usedColors[5]);
    }

    public void OpenSettings()
    {
            settingsPanel.SetActive(true);
            backgroundPanel.SetActive(true);
            Time.timeScale = 0;
            DataScript.isGamePaused = true;
            exitButton.gameObject.SetActive(true);
            settingsButton.gameObject.SetActive(false);
    }

    public void CloseButtonPressed()
    {
        if (settingsPanel.activeSelf)
            settingsPanel.SetActive(false);
        if (levelsPanel.activeSelf)
            levelsPanel.SetActive(false);
        if (backgroundPanel.activeSelf)
            backgroundPanel.SetActive(false);
        Time.timeScale = 2.5f;
        DataScript.isGamePaused = false;
        exitButton.gameObject.SetActive(false);
        settingsButton.gameObject.SetActive(true);
        
    }

    public void OpenLevelsPanel()
    {
        if (settingsPanel.activeSelf)
            settingsPanel.SetActive(false);
        levelsPanel.SetActive(true);
        
    }

    public void LevelAccomplished()
    {
        DataScript.gameOverLock = false;
        FB.LogAppEvent(AppEventName.AchievedLevel, (float)DataScript.currentLevel);
        levelAccomplishedPanel.SetActive(true);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void GameStarted()
    {
        if (startingText.gameObject.activeSelf)
        {
            startingText.gameObject.SetActive(false);
        }
        
    }
}
