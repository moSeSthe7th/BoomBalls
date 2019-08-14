using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusLevelText : MonoBehaviour
{
    private Text text;
    
    void Start()
    {
        StartCoroutine(bonusLevelEnum());
    }

   
    void Update()
    {
        GetComponent<Text>().color = DataScript.textColor;
    }

    private IEnumerator bonusLevelEnum()
    {
        if (gameObject.activeSelf)
        {
            yield return new WaitForSecondsRealtime(1.25f);
            gameObject.SetActive(false);
        }
    }
}
