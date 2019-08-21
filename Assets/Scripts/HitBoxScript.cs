using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitBoxScript : MonoBehaviour
{
    public int count;

    private Text countText;
    private Text congratulationsText;

    private UIScript uIScript;
    private bool isFinished;

    private string[] congratulationsStrings;

    Vector3 congratulationsTextStartingPosHolder = new Vector3();
    Vector4 congratulationsTextColorHolderAtStart = new Vector4();

    public GameObject boxParticleSystemGameobject;
    private ParticleSystem boxParticleSystem;

    bool isObjectAtRight;

    void Start()
    {
        congratulationsStrings = new string[7] { "GOOD!", "NICE!", "GREAT!", "PERFECT!!!", "WOW!!!" , "AMAZING!", "COOL!"};
        uIScript = FindObjectOfType(typeof(UIScript)) as UIScript;
        countText = GetComponentsInChildren<Text>()[0];
        congratulationsText = GetComponentsInChildren<Text>()[1];
        congratulationsText.gameObject.SetActive(false);
        isFinished = false;
        isObjectAtRight = false;

        
        if(gameObject.transform.position.x < 0)
        {
            Vector3 firstDummyPosVec = new Vector3();
            firstDummyPosVec = congratulationsText.gameObject.transform.position;
            firstDummyPosVec.x += 5f;
            congratulationsText.gameObject.transform.position = firstDummyPosVec;
            isObjectAtRight = true;
        }

        congratulationsTextStartingPosHolder = congratulationsText.gameObject.transform.position;
        congratulationsTextColorHolderAtStart = DataScript.textColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Ball" && count>0)
        {
            boxParticleSystem = Instantiate(boxParticleSystemGameobject, collision.contacts[0].point, Quaternion.identity).GetComponent<ParticleSystem>();
            boxParticleSystem.Play();

            count--;
            SetCountText();

            if(count == 0)
                StartCoroutine(CreateCongratulationsText(false));       //bunu true yaparsan son seyde hep perfect yapar... asağıda da random secilen integer i nin range ini 0-3 e değistir
            else
                StartCoroutine(CreateCongratulationsText(false));

        }

        if(count == 0 && !isFinished)
        {
            Debug.Log("One Box Finished");
            DataScript.finishedBoxCount += 1;
            isFinished = true;

            Debug.Log("Finished / Box Count: " + DataScript.finishedBoxCount + " / " + DataScript.boxCountInLevel);
            if(DataScript.finishedBoxCount == DataScript.boxCountInLevel)
            {
                if(DataScript.currentLevel == DataScript.maxReachedLevel)
                {
                    
                    if(DataScript.maxReachedLevel != DataScript.totalLevelCount)
                    {
                        
                        DataScript.maxReachedLevel += 1;
                        PlayerPrefs.SetInt("Max Reached Level", DataScript.maxReachedLevel);
                        
                    }
                    
                }
                uIScript.LevelAccomplished();
                Debug.Log("Level Finished");
            }
        }
    }

    
    public void SetCountText()
    {
        countText.text = count.ToString();
    }

    public IEnumerator CreateCongratulationsText(bool isFinishedForCongratulationsText)
    {
        congratulationsText.gameObject.transform.position = congratulationsTextStartingPosHolder;
        Vector3 dummyPosVec = new Vector3();
        congratulationsText.color = congratulationsTextColorHolderAtStart;

        if (isFinishedForCongratulationsText)
            congratulationsText.text = congratulationsStrings[3].ToString();
        else
        {
            int i = Random.Range(0, 7);
            congratulationsText.text = congratulationsStrings[i].ToString();
        }
        
        congratulationsText.gameObject.SetActive(true);
        
        for(int j = 0; j<10; j++)
        {
            Vector4 colorDummy;

            dummyPosVec = congratulationsText.gameObject.transform.position;
            dummyPosVec.y += 0.2f;
            if (isObjectAtRight)
                dummyPosVec.x += 0.1f;
            else
                dummyPosVec.x -= 0.1f;

            congratulationsText.gameObject.transform.position = dummyPosVec;
            colorDummy = congratulationsText.color;

            colorDummy.w -= 0.1f;
            congratulationsText.color = colorDummy;
            yield return new WaitForSecondsRealtime(0.1f);
        }
        congratulationsText.gameObject.SetActive(false);
        
    }
}
