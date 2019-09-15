using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(rotateLeft());
    }

    public IEnumerator rotateRight()
    {
        while (true)
        {
            gameObject.transform.Rotate(Vector3.forward, 10f);
            yield return new WaitForSecondsRealtime(Time.deltaTime);
        }
       
    }

    public IEnumerator rotateLeft()
    {
        while (true)
        {
            gameObject.transform.Rotate(Vector3.forward, -10f);
            yield return new WaitForSecondsRealtime(Time.deltaTime);
        }

    }
}
