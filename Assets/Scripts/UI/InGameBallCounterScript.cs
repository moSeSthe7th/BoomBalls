using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameBallCounterScript : MonoBehaviour
{
    private Text inGameCounterText;

    private void Start()
    {
        inGameCounterText = GetComponent<Text>();
    }

    public void SetInGameBallCounter()
    {
        inGameCounterText.text = DataScript.ballCount.ToString();
    }
}
