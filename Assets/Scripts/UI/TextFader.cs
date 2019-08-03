using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFader : MonoBehaviour
{
    private Text text;
    private Color dummyColor;
    
    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine(Fader());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fader()
    {
        dummyColor = text.color;
        while (gameObject.activeSelf)
        {
            dummyColor.a = Mathf.PingPong(Time.time/2.5f, 1f);
            text.color = dummyColor;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }
}
