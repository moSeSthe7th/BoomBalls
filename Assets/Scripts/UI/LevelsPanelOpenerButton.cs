using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsPanelOpenerButton : MonoBehaviour
{
    private UIScript uIScript;

    void Start()
    {
        uIScript = FindObjectOfType(typeof(UIScript)) as UIScript;
    }

    public void OpenLevelsPanel()
    {
        uIScript.OpenLevelsPanel();
    }
}
