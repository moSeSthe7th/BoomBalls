using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    private Vector2 screenBounds;

    //enum Direction { up,down,right,left};

    //Direction currentDir;

    bool isMovingVertical;

    private Vector3 dummyPos;

    /*private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.5f));
        isMovingVertical = true;
    }*/

    private void Update()
    {
        Vector3 screenPoint = Input.mousePosition;
        screenPoint.z = Camera.main.transform.position.z - 0.5f;
        

        dummyPos = Camera.main.ScreenToWorldPoint(screenPoint);
        dummyPos.z = 0.5f;

        transform.position = dummyPos;

        /*if (Input.GetMouseButton(0))
        {
            if(Input.GetAxis("Mouse X") < 0)
            {
                if (isMovingVertical)
                {
                    basketPos = gameObject.transform.position;
                    basketPos.y -= 0.1f;
                    gameObject.transform.position = basketPos;
                }
                else
                {
                    basketPos = gameObject.transform.position;
                    basketPos.y -= 0.1f;
                    gameObject.transform.position = basketPos;
                }
            }
        }*/
    }

    
    
}
