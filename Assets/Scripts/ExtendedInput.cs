using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtendedInput 
{

#if UNITY_EDITOR || UNITY_IPHONE
        public static bool isInputEntered()
        {
            if (Input.GetMouseButtonDown(0))
                return true;

            return false;
        }

        public static bool isInput()
        {
            if (Input.GetMouseButton(0))
                return true;

            return false;
        }

        public static bool isInputExited()
        {
            if (Input.GetMouseButtonUp(0))
                return true;

            return false;
        }

        public static Vector3 GetPoint()
        {
            return Input.mousePosition;
        }

#elif UNITY_IPHONE && !UNITY_EDITOR
        public static bool isInputEntered()
        {
            if (Input.touchCount > 0)
                if(Input.GetTouch(0).phase == TouchPhase.Began)
                    return true;

            return false;
        }

        public static bool isInput()
        {
            if (Input.touchCount > 0)
                return true;

            return false;
        }


        public static bool isInputExited()
        {
            if (Input.touchCount <= 0)
                return true;

            return false;
        }

        public static Vector3 GetPoint()
        {
            return Input.touches[0].position;
        }
#endif

}
