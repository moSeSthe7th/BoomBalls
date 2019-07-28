using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsPanelScript : MonoBehaviour
{
    public GameObject levelButtonObj;
    public GameObject Content;

    void Start()
    {
        
    }

    public void CreateLevelsPanelWithColor(Sprite sprite)
    {
        for (int i = 1; i <= DataScript.totalLevelCount; i++)
        {
            GameObject obj = Instantiate(levelButtonObj);
            obj.gameObject.GetComponentInChildren<Text>().text = i.ToString();
            obj.transform.SetParent(Content.transform);
            obj.GetComponent<Image>().sprite = sprite;
            if (i > DataScript.maxReachedLevel)
            {
                obj.gameObject.GetComponentInChildren<Button>().interactable = false;
                Debug.Log("Max Reached Level: " + DataScript.maxReachedLevel);
            }
        }
    }
}
