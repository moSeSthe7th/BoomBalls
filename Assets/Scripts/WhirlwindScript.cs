using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirlwindScript : MonoBehaviour
{
   

    public IEnumerator InitializeWhirlWind(bool isRotatingClockwise)
    {
        if (isRotatingClockwise)
        {
            while (true)
            {
                gameObject.transform.Rotate(0, 0, 10f);
                yield return new WaitForSecondsRealtime(0.01f);
            }
        }
        else
        {
            while (true)
            {
                gameObject.transform.Rotate(0, 0, -10f);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            
        }
    }
}
