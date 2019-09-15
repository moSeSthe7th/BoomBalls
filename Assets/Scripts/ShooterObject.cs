using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterObject : MonoBehaviour
{
    Vector3 LastPosition;

    bool canShoot;

    private void Start()
    {
        canShoot = true;
        LastPosition = transform.position;
    }

    void Update()
    {
        float diff = transform.position.x - LastPosition.x;

        if (!Mathf.Approximately(transform.position.x, LastPosition.x))
        {
            transform.position = Vector3.MoveTowards(transform.position, LastPosition, 8f * Time.deltaTime * Mathf.Abs(diff));
            if (canShoot == false && Mathf.Abs(diff) < 1f)
            {
                canShoot = true;
            }
        }
        /*else if(canShoot == false && Mathf.Abs(diff) < 2f)
        {
            canShoot = true;
            Debug.Log(canShoot);
        }*/
    }

    public void ShootPressed(Vector3 pos)
    {
        LastPosition = pos;
        canShoot = false;
    }

    public bool CanShoot()
    {
        return canShoot;
    }
}
