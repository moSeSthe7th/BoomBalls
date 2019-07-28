using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObjectScript : MonoBehaviour
{
    public bool isTrampoline;
    public bool isTrampolinedToRight;
    public float rotateAngle;

    private Rigidbody rbBall;
    private FixedJoint fixedJoint;

    public GameObject rotatingObjectParticleSystemObj;
    private ParticleSystem rotatingObjectParticleSystem;

    void Start()
    {
        
        rotateAngle = 45f;

        if (isTrampoline)
        {
            StartCoroutine(becomeTrampoline(isTrampolinedToRight));
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rotatingObjectParticleSystem = Instantiate(rotatingObjectParticleSystemObj, collision.contacts[0].point, Quaternion.identity).GetComponent<ParticleSystem>();
        rotatingObjectParticleSystem.Play();

        if(collision.gameObject.tag == "Ball")
        {
            rbBall = collision.gameObject.GetComponent<Rigidbody>();

            if (collision.contacts[0].point.x <= transform.position.x && !isTrampoline)
            {
                
                Debug.Log("Entered Collision from right");
                StartCoroutine(becomeTrampoline(true));

            }
            else if(collision.contacts[0].point.x >= transform.position.x && !isTrampoline)
            {
                
                Debug.Log("Entered Collision from left");
                StartCoroutine(becomeTrampoline(false));
                
            }
            else
            {
                Debug.Log("Entered trampoline part");

                StartCoroutine(becomeNormal());
                
            }
        }
    }
   
    public IEnumerator becomeNormal()
    {
        if(transform.rotation.eulerAngles.z >= 180f)
        {
            rbBall.velocity = new Vector3(22f, 22f, 0f);

            while (transform.rotation.eulerAngles.z >= 180f)
            {
                transform.Rotate(0f, 0f, 2f);
                yield return new WaitForSecondsRealtime(0.01f);
            }
        }
        else if(gameObject.transform.rotation.eulerAngles.z <= 180f)
        {
            rbBall.velocity = new Vector3(-22f, 22f, 0f);

            while (transform.rotation.eulerAngles.z <= 180f)
            {
                transform.Rotate(0f, 0f, -2f);
                yield return new WaitForSecondsRealtime(0.01f);
            }
        }

        yield return new WaitForSecondsRealtime(0.2f);
        transform.rotation = Quaternion.identity;
        isTrampoline = false;
    }

    public IEnumerator becomeTrampoline(bool isHitRight)
    {
        
        if (isHitRight)
        {
            while (transform.rotation.eulerAngles.z < rotateAngle)
            {
                transform.Rotate(0f, 0f, 2f);
                yield return new WaitForSecondsRealtime(0.01f);
                
            }
            
        }
        else
        {
            if(transform.rotation.eulerAngles.z == 0)
                transform.Rotate(0f, 0f, -1f);
            while (transform.rotation.eulerAngles.z > (360-rotateAngle))
            {
                
                transform.Rotate(0f, 0f, -2f);
                yield return new WaitForSecondsRealtime(0.01f);
            }
            
        }

        yield return new WaitForSecondsRealtime(0.6f);
        isTrampoline = true;
    }

    
}
