using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirlwindScript : MonoBehaviour
{
   

    public IEnumerator InitializeWhirlWind(bool isRotatingClockwise,float rotatingSpeed,float delay)
    {
        yield return new WaitForSecondsRealtime(delay);

        if (isRotatingClockwise)
        {
            while (true)
            {
                gameObject.transform.Rotate(0, 0, rotatingSpeed);
                yield return new WaitForSecondsRealtime(0.01f);
            }
        }
        else
        {
            while (true)
            {
                gameObject.transform.Rotate(0, 0, -1*rotatingSpeed);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            
        }
    }
}
