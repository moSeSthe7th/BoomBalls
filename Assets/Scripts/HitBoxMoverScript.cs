using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxMoverScript : MonoBehaviour
{

    private Vector3 dummyPosVec;
    private Vector3 startingPosHolder;
   


    public IEnumerator HitBoxOscillator(bool isMovingHorizontal)
    {
        dummyPosVec = transform.position;
        startingPosHolder = transform.position;

        if (isMovingHorizontal)
        {
            bool isMovingRight = true;
            float i = startingPosHolder.x;

            while (true)
            {
                Debug.Log("Is moving Right " + isMovingRight);
                
                do
                {
                    if (isMovingRight)
                    {
                        i -= 0.3f;
                        dummyPosVec.x = i;
                        transform.position = dummyPosVec;
                    }
                    else
                    {
                        i += 0.3f;
                        dummyPosVec.x = i;
                        transform.position = dummyPosVec;
                    }

                    yield return new WaitForSecondsRealtime(0.1f);
                } while (startingPosHolder.x - 1.5f < i && i < startingPosHolder.x + 1.5f);
                
                isMovingRight = !isMovingRight;
            }
        }
        else
        {
            bool isMovingUp = true;
            float i = startingPosHolder.y;

            while (true)
            {
                do
                {
                    if (isMovingUp)
                    {
                        i += 0.3f;
                        dummyPosVec.y = i;
                        transform.position = dummyPosVec;
                    }
                    else
                    {
                        i -= 0.3f;
                        dummyPosVec.y = i;
                        transform.position = dummyPosVec;
                    }

                    yield return new WaitForSecondsRealtime(0.1f);
                } while (startingPosHolder.y - 1.5f < i && i < startingPosHolder.y + 1.5f);

                isMovingUp = !isMovingUp;
            }
        }
    }
}
