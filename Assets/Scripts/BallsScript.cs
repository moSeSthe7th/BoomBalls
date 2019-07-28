using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsScript : MonoBehaviour
{
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
        //rigidbody.velocity = new Vector3(0f, -20f, 0f);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        rigidbody.velocity = Vector3.zero;
    }

  
}
