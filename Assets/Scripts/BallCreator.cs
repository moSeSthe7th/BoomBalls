using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    private ObjectPooler objectPooler;
    public GameObject ball;
    private List<GameObject> ballsList;
    private GameObject selectedBall;

    private InGameBallCounterScript counterScript;
    private UIScript uIScript;

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
    }

    private void Update()
    {
        #region TouchControls
        if (Input.touchCount > 0 && !DataScript.isGamePaused && DataScript.ballCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                selectedBall = objectPooler.GetPooledObject(ballsList);
                if (selectedBall != null)
                {

                    DataScript.ballCount -= 1;
                    counterScript.SetInGameBallCounter();

                    Vector3 screenPoint = touch.position;
                    screenPoint.z = Camera.main.transform.position.z - 0.5f;

                    dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);

                    dummyPos.y = 16f;
                    dummyPos.z = 0.5f;

                    selectedBall.transform.position = dummyPos;
                    selectedBall.SetActive(true);
                }
            }
        }
#endregion

        #region MouseControls
        else if (Input.GetMouseButtonDown(0) && !DataScript.isGamePaused && DataScript.ballCount > 0)
        {
            selectedBall = objectPooler.GetPooledObject(ballsList);
            if (selectedBall != null)
            {
                
                DataScript.ballCount -= 1;
                counterScript.SetInGameBallCounter();
               
                Vector3 screenPoint = Input.mousePosition;
                screenPoint.z = Camera.main.transform.position.z - 0.5f;

                dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);
                
                dummyPos.y = 16f;
                dummyPos.z = 0.5f;

                selectedBall.transform.position = dummyPos;
                selectedBall.SetActive(true);
            }
            
        }

        if (DataScript.ballCount == 0 && GameObject.FindWithTag("Ball") == null)
        {
            uIScript.GameOver();
        }
        #endregion
    }

}
