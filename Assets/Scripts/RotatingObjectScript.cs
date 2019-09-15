using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObjectScript : MonoBehaviour
{
    enum RotateState
    {
        Horizaontal,
        Rotated,
        RotateRight,
        RotateLeft
    }

    RotateState state;

    public bool isTrampoline;
    public bool isTrampolinedToRight;
    public float rotateAngle;

    private Rigidbody rbBall;
    private FixedJoint fixedJoint;

    public GameObject rotatingObjectParticleSystemObj;
    private ParticleSystem rotatingObjectParticleSystem;

    float rotationSpeed; //Corountine lerdeki dönme hızı ve zamanları kolay değiştirilebilsin diye
    float timeIndex;

    void Start()
    {
        rotateAngle = 45f;

        rotationSpeed = 2f;
        timeIndex = 0.01f;

        if (isTrampoline)
        {
            state = RotateState.Rotated;
            StartCoroutine(becomeTrampoline(isTrampolinedToRight));
        }
        else
            state = RotateState.Horizaontal;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rotatingObjectParticleSystem = Instantiate(rotatingObjectParticleSystemObj, collision.contacts[0].point, Quaternion.identity).GetComponent<ParticleSystem>();
        rotatingObjectParticleSystem.Play();

        if(collision.gameObject.tag == "Ball")
        {
            rbBall = collision.gameObject.GetComponent<Rigidbody>();

            if(isTrampoline)
            {

            }

            if (collision.contacts[0].point.x <= transform.position.x && !isTrampoline)
            {
                Debug.Log("Entered Collision from right");
                StartCoroutine(becomeTrampoline(true));
            }
            else if(collision.contacts[0].point.x >= transform.position.x && state != RotateState.Rotating && isTrampoline)
            {
                Debug.Log("Entered Collision from left");
                StartCoroutine(becomeTrampoline(false));
            }
            else if(state != RotateState.Rotating)
            {
                Debug.Log("Entered trampoline part");
                StartCoroutine(becomeNormal());
            }
        }
    }

    private void Update()
    {
        if(state == RotateState.RotateRight)
        {
            if(transform.rotation.eulerAngles.z < rotateAngle)
            {
                transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            }
            else
            {
                state = RotateState.Rotated;
                transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, rotateAngle));
            }
        }
        else if(state == RotateState.RotateLeft)
        {
            if (transform.rotation.eulerAngles.z < rotateAngle)
            {
                transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
            }
            else
            {
                state = RotateState.Rotated;
                transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 360 - rotateAngle));
            }
        }
    }

    public IEnumerator becomeNormal()
    {
        //state = RotateState.Rotating;
        if (transform.rotation.eulerAngles.z >= 180f)
        {
            rbBall.velocity = new Vector3(22f, 22f, 0f);

            while (transform.rotation.eulerAngles.z >= 180f)
            {
                transform.Rotate(0f, 0f, rotationSpeed);
                yield return new WaitForSecondsRealtime(timeIndex);
            }
        }
        else if(gameObject.transform.rotation.eulerAngles.z <= 180f)
        {
            rbBall.velocity = new Vector3(-22f, 22f, 0f);

            while (transform.rotation.eulerAngles.z <= 180f)
            {
                transform.Rotate(0f, 0f, -rotationSpeed);
                yield return new WaitForSecondsRealtime(timeIndex);
            }
        }

        isTrampoline = false;

        yield return new WaitForSecondsRealtime(0.2f);
        transform.rotation = Quaternion.identity;

        state = RotateState.Horizaontal;
    }

    public IEnumerator becomeTrampoline(bool isHitRight)
    {
        //state = RotateState.Rotating;

        if (isHitRight)
        {
            isTrampolinedToRight = true;
            while (transform.rotation.eulerAngles.z < rotateAngle)
            {
                transform.Rotate(0f, 0f, rotationSpeed);
                yield return new WaitForSecondsRealtime(timeIndex);
            }
            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, rotateAngle));
        }
        else
        {
            isTrampolinedToRight = false;
            while (transform.rotation.eulerAngles.z > (360-rotateAngle))
            {
                transform.Rotate(0f, 0f, -rotationSpeed);
                yield return new WaitForSecondsRealtime(timeIndex);
            }

            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y,360 - rotateAngle));
        }

        yield return new WaitForSecondsRealtime(0.6f);
        isTrampoline = true;

        state = RotateState.Rotated;

    }


}
