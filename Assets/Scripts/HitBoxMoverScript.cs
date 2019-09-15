using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxMoverScript : MonoBehaviour
{
   
    
    private Vector3 startingPosHolder;
   


    public IEnumerator HitBoxOscillator(bool isMovingHorizontal, float speed, float waitingTime)
    {
        
        startingPosHolder = transform.position;

        if (isMovingHorizontal)
        {
            bool isMovingRight = true;
            

            while (true)
            {
                do
                {
                    if (isMovingRight)
                    {
                        
                        transform.Translate(Vector3.right * speed, Space.Self);
                    }
                    else
                    {
                       
                        transform.Translate(Vector3.left * speed, Space.Self);
                    }

                    yield return new WaitForSecondsRealtime(waitingTime);
                } while (startingPosHolder.x - 1.5f < transform.position.x && transform.position.x < startingPosHolder.x + 1.5f);
                
                isMovingRight = !isMovingRight;
            }
        }
        else
        {
            bool isMovingUp = true;
            
            while (true)
            {
                do
                {
                    if (isMovingUp)
                    {
                        transform.Translate(Vector3.up * speed, Space.Self);
                    }
                    else
                    {
                        transform.Translate(Vector3.down * speed, Space.Self);
                    }

                    yield return new WaitForSecondsRealtime(waitingTime);
                } while (startingPosHolder.y - 1.5f < transform.position.y && transform.position.y < startingPosHolder.y + 1.5f);

                isMovingUp = !isMovingUp;
            }
        }
    }
}
