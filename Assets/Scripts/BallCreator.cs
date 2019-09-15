using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    private ObjectPooler objectPooler;
    public GameObject ball;
    private List<GameObject> ballsList;
    private GameObject selectedBall;
    //public GameObject ballShooter;

    private InGameBallCounterScript counterScript;
    private UIScript uIScript;
    
    ShooterObject ballShooter;

    Queue<Vector3> ShootEvent;
    Vector3 GoToPosition;

    //private float selectedBallx;
    //private float selectedBally;

    //private Vector3 selectedBallPos;

    private Vector3 dummyPos;
    private Vector3 ballShooterPos;

    float timeBetweenInputs;
    float inputTimer;

    void Start()
    {
        objectPooler = FindObjectOfType(typeof(ObjectPooler)) as ObjectPooler;
        ballsList = objectPooler.PooltheObjects(ball, 20);
        counterScript = FindObjectOfType(typeof(InGameBallCounterScript)) as InGameBallCounterScript;
        uIScript = FindObjectOfType(typeof(UIScript)) as UIScript;
        ballShooterPos = DataScript.screenTopCenter;
        ballShooterPos.y -= 2f;

        ballShooter = FindObjectOfType(typeof(ShooterObject)) as ShooterObject;
        this.transform.position = ballShooterPos;

        ShootEvent = new Queue<Vector3>();

        timeBetweenInputs = 0.5f;
    }

    private void Update()
    {
        if(ShootEvent.Count > 0)
        {
            float diff = transform.position.x - GoToPosition.x;

            if (Mathf.Abs(diff) > 1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, GoToPosition, 8f * Time.deltaTime * Mathf.Abs(diff));
            }
            else
            {
                transform.position = GoToPosition;
                SendBall();
            }
        }

        inputTimer += Time.deltaTime;
        if (ExtendedInput.isInput() && inputTimer > timeBetweenInputs)
        {
            inputTimer = 0f;
            ProcessNewInput();
        }

        if (DataScript.ballCount == 0 && DataScript.gameOverLock)
        {
            GameObject[] ballsInScene = GameObject.FindGameObjectsWithTag("Ball");

            if(ballsInScene == null)
            {
                uIScript.GameOver();
            }
            else
            {
                bool isAnyBallMoving = false;

                foreach (GameObject b in ballsInScene)
                {
                    if (!Mathf.Approximately(b.GetComponent<Rigidbody>().velocity.magnitude, 0f))
                    {
                        isAnyBallMoving = true;
                    }
                }

                if(isAnyBallMoving == false)
                {
                    uIScript.GameOver();
                }
            }

        }
        
    }

    void ProcessNewInput()
    {
        Vector3 screenPoint = ExtendedInput.GetPoint();
        screenPoint.z = Camera.main.transform.position.z - 0.5f;

        dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);
        ShootEvent.Enqueue(dummyPos);

        dummyPos.y = ballShooterPos.y;
        dummyPos.z = 0.5f;

        GoToPosition = dummyPos;

        uIScript.GameStarted();
    }

    void SendBall()
    {
        if (DataScript.ballCount > 0)
        {
            selectedBall = objectPooler.GetPooledObject(ballsList);

            if (selectedBall != null)
            {
                Vector3 ballPos = ShootEvent.Dequeue();
                Debug.Log("SendBall: Ball position is : " + ballPos);

                if (ballPos.y < DataScript.screenTopCenter.y - 5f)
                {
                    ballPos.y = DataScript.screenTopCenter.y - 4f;
                    ballPos.z = 0.5f;

                    DataScript.ballCount -= 1;
                    counterScript.SetInGameBallCounter();
                    selectedBall.transform.position = ballPos;
                    selectedBall.SetActive(true);
                    selectedBall.GetComponent<Rigidbody>().velocity = new Vector3(0f, -12f, 0f);
                }


            }
        }
    }
}


/*  public IEnumerator SendBallsTouch()
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

              if(dummyPos.y < DataScript.screenTopCenter.y - 5f)
              {
                  dummyPos.y = DataScript.screenTopCenter.y - 4f;
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

              if(dummyPos.y <= DataScript.screenTopCenter.y-5f)
              {
                  dummyPos.y = DataScript.screenTopCenter.y - 4f;
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
  }*/
