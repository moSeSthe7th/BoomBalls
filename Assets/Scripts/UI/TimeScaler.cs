using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScaler : MonoBehaviour
{
    public void TimeScaleChange(float timeChangeAmount)
    {
        Time.timeScale += timeChangeAmount;
        gameObject.GetComponentInChildren<Text>().text = Time.timeScale.ToString();
    }
}
