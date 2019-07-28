using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    private UIScript uIScript;

    void Start()
    {
        uIScript = FindObjectOfType(typeof(UIScript)) as UIScript;
    }

    public void CloseButtonPressed()
    {
        uIScript.CloseButtonPressed();
    }
}
