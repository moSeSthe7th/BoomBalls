using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    private ObjectPooler objectPooler;
    public GameObject ball;
    private List<GameObject> ballsList;
    private GameObject selectedBall;
    public GameObject ballShooter;

    private InGameBallCounterScript counterScript;
    private UIScript uIScript;

    private bool isCoroutineStarted;

    //private float selectedBallx;
    //private float selectedBally;

    //private Vector3 selectedBallPos;

    private Vector3 dummyPos;

    void Start()
    {
        objectPooler = FindObjectOfType(typeof(ObjectPooler)) as ObjectPooler;
        ballsList = objectPooler.PooltheObjects(ball, 20);
        counterScript = FindObjectOfType(typeof(InGameBallCounterScript)) as InGameBallCounterScript;
        uIScript = FindObjectOfType(typeof(UIScript)) as UIScript;

        ballShooter.transform.position = DataScript.screenTopCenter;

        isCoroutineStarted = false;
    }

    private void Update()
    {
        #region TouchControls
        if (Input.touchCount > 0 && !DataScript.isGamePaused && DataScript.ballCount > 0)
        {
            uIScript.GameStarted();
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                StartCoroutine(SendBallsTouch());
            }

            Vector3 screenPoint = touch.position;
            screenPoint.z = Camera.main.transform.position.z - 0.5f;

            dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);

            dummyPos.y = DataScript.screenTopCenter.y;
            dummyPos.z = 0.5f;

            ballShooter.transform.position = dummyPos;
        }
#endregion

        #region MouseControls
        else if (Input.GetMouseButton(0) && !DataScript.isGamePaused && DataScript.ballCount > 0)
        {
            Vector3 screenPoint = Input.mousePosition;
            screenPoint.z = Camera.main.transform.position.z - 0.5f;

            dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);

            dummyPos.y = DataScript.screenTopCenter.y;
            dummyPos.z = 0.5f;

            ballShooter.transform.position = dummyPos;

            uIScript.GameStarted();
            if (!isCoroutineStarted)
            {
                StartCoroutine(SendBallsMouse());
            }
            
        }
        #endregion
        if (DataScript.ballCount == 0 && GameObject.FindWithTag("Ball") == null && DataScript.gameOverLock)
        {
            uIScript.GameOver();
        }
        
    }

    public IEnumerator SendBallsTouch()
    {
        while(Input.touchCount > 0 && DataScript.ballCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            selectedBall = objectPooler.GetPooledObject(ballsList);
            if (selectedBall != null)
            {

               
                Vector3 screenPoint = touch.position;
                screenPoint.z = Camera.main.transform.position.z - 0.5f;

                dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);

                if(dummyPos.y < 12f)
                {
                    dummyPos.y = DataScript.screenTopCenter.y - 3f;
                    dummyPos.z = 0.5f;

                    DataScript.ballCount -= 1;
                    counterScript.SetInGameBallCounter();


                    selectedBall.transform.position = dummyPos;
                    selectedBall.SetActive(true);
                    selectedBall.GetComponent<Rigidbody>().velocity = new Vector3(0f, -12f, 0f);
                }

                
            }
            yield return new WaitForSecondsRealtime(0.15f);
        }
    }


    public IEnumerator SendBallsMouse()
    {
        isCoroutineStarted = true;
        while (Input.GetMouseButton(0) && DataScript.ballCount > 0)
        {
            selectedBall = objectPooler.GetPooledObject(ballsList);
            if (selectedBall != null)
            {

                
                Vector3 screenPoint = Input.mousePosition;
                screenPoint.z = Camera.main.transform.position.z - 0.5f;

                dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);

                if(dummyPos.y < 12f)
                {
                    dummyPos.y = DataScript.screenTopCenter.y - 3f;
                    dummyPos.z = 0.5f;


                    DataScript.ballCount -= 1;
                    counterScript.SetInGameBallCounter();


                    selectedBall.transform.position = dummyPos;
                    selectedBall.SetActive(true);
                    selectedBall.GetComponent<Rigidbody>().velocity = new Vector3(0f, -12f, 0f);
                }
                
            }
            yield return new WaitForSecondsRealtime(0.15f);
        }
        isCoroutineStarted = false;
    }
}
