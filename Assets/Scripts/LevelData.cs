using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public List<Box> boxes;
    public List<RotatingObject> rotatingObjects;
    public string levelStyle;
    public int ballCount;

    public float cameraScale;

    public List<Vector3> obstaclePositions;

    public bool isLevelReversed;

    public struct RotatingObject
    {
        public Vector3 position;
        public bool isTrampoline;
        public bool isTrampolinedRight;
        public Vector3 scale;

        public RotatingObject(Vector3 pos, bool isTr, Vector3 Scale, bool IsTrampolinedRight)
        {
            this.position = pos;
            this.isTrampoline = isTr;
            this.scale = Scale;
            this.isTrampolinedRight = IsTrampolinedRight;
        }
    }

    public struct Box
    {
        public Vector3 position;
        public int count;

        public Box(Vector3 pos, int cnt)
        {
            this.position = pos;
            this.count = cnt;
        }
    }

    public void LoadLevelData(int levelNumber)
    {
        List<Box> boxesInner = new List<Box>();
        List<RotatingObject> rotatingObjectsInner = new List<RotatingObject>();

        switch (levelNumber)
        {
            case 1:
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(6f, -10f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(8f, 4f, 0.5f), 20));

                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0f, 0f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 500;

                cameraScale = 37f;

                levelStyle = "Red";

                isLevelReversed = false;

                break;

            case 2:
                boxesInner.Add(new Box(new Vector3(8f, 0, 0.5f), 30));
                boxesInner.Add(new Box(new Vector3(-8f, 0, 0.5f), 30));
                boxesInner.Add(new Box(new Vector3(8f, -9f, 0.5f), 30));

                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-3f, 4f, 0.5f), false, new Vector3(10f, 1f, 1f), false));

                ballCount = 500;

                cameraScale = 37f;

                levelStyle = "Orange";

                isLevelReversed = false;

                break;

            case 3:
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(-3f, -10f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(8f, -10f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(8f, -2f, 0.5f), 40));

                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(4f, -4f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Yellow";

                isLevelReversed = false;

                break;

            case 4:
                boxesInner.Add(new Box(new Vector3(-5f, -13f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(-8f, 12f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(8f, 7f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(-8f, 12f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(7f, -14f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(8f, 0f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(-8f, 3f, 0.5f), 50));

                obstaclePositions.Add(new Vector3(-5f, -5f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, 5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -2f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -12f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Green";

                isLevelReversed = false;

                break;


            case 5:
               
                boxesInner.Add(new Box(new Vector3(3f, 3f, 0.5f), 6));
                boxesInner.Add(new Box(new Vector3(5f, -14f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(0, -12f, 0.5f), 20));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(8f, -8f, 0.5f), true, new Vector3(4f, 1f, 1f), true));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -5f, 0.5f), true, new Vector3(4f, 1f, 1f), true));
                

                obstaclePositions.Add(new Vector3(-4f, 3f, 0.5f));



                ballCount = 500;

                cameraScale = 37f;

                levelStyle = "Blue";

                isLevelReversed = false;

                break;

            case 6:
                boxesInner.Add(new Box(new Vector3(2f, -14f, 0.5f), 1));
                boxesInner.Add(new Box(new Vector3(8f, 6f, 0.5f), 1));
                boxesInner.Add(new Box(new Vector3(2f, -14f, 0.5f), 1));
                boxesInner.Add(new Box(new Vector3(-8f, 10f, 0.5f), 1));



                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0, 4f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(6f, -8f, 0.5f), true, new Vector3(6f, 1f, 1f), true));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-5f, 0f, 0.5f), true, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 50f;

                levelStyle = "Purple";

                isLevelReversed = false;

                break;

            case 7:
                boxesInner.Add(new Box(new Vector3(-8f, 9f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-8f, 3f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-10f, -14f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-8f, -1f, 0.5f), 20));


                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, 2f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-1f, -3, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -8f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Purple";

                isLevelReversed = false;

                break;

            case 8:
                boxesInner.Add(new Box(new Vector3(0f, -10f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(6.5f, 8f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-5.5f, 8f, 0.5f), 20));

                obstaclePositions.Add(new Vector3(6.5f, 11f, 0.5f));
                obstaclePositions.Add(new Vector3(-5.5f, 11f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(6f, 0, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-5f, 0, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                

                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Purple";

                isLevelReversed = false;

                break;

            case 9:
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(6f, -10f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(8f, 4f, 0.5f), 20));

                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0f, 0f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 500;

                cameraScale = 37f;

                levelStyle = "Red";

                isLevelReversed = true;

                break;

            case 10:
                boxesInner.Add(new Box(new Vector3(8f, 0, 0.5f), 30));
                boxesInner.Add(new Box(new Vector3(-8f, 0, 0.5f), 30));
                boxesInner.Add(new Box(new Vector3(8f, -9f, 0.5f), 30));

                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-3f, 4f, 0.5f), false, new Vector3(10f, 1f, 1f), false));

                ballCount = 500;

                cameraScale = 37f;

                levelStyle = "Orange";

                isLevelReversed = true;

                break;

            case 11:
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(-3f, -10f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(8f, -10f, 0.5f), 40));
                boxesInner.Add(new Box(new Vector3(8f, -2f, 0.5f), 40));

                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(4f, -4f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Yellow";

                isLevelReversed = true;

                break;

            case 12:
                boxesInner.Add(new Box(new Vector3(-5f, -13f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(-8f, 12f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(8f, 7f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(-8f, 12f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(7f, -14f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(8f, 0f, 0.5f), 50));
                boxesInner.Add(new Box(new Vector3(-8f, 3f, 0.5f), 50));

                obstaclePositions.Add(new Vector3(-5f, -5f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, 5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -2f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -12f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Green";

                isLevelReversed = true;

                break;


            case 13:

                boxesInner.Add(new Box(new Vector3(3f, 3f, 0.5f), 6));
                boxesInner.Add(new Box(new Vector3(5f, -14f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(0, -12f, 0.5f), 20));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(8f, -8f, 0.5f), true, new Vector3(4f, 1f, 1f), true));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -5f, 0.5f), true, new Vector3(4f, 1f, 1f), true));


                obstaclePositions.Add(new Vector3(-4f, 3f, 0.5f));



                ballCount = 500;

                cameraScale = 37f;

                levelStyle = "Blue";

                isLevelReversed = true;

                break;

            case 14:
                boxesInner.Add(new Box(new Vector3(2f, -14f, 0.5f), 1));
                boxesInner.Add(new Box(new Vector3(8f, 6f, 0.5f), 1));
                boxesInner.Add(new Box(new Vector3(2f, -14f, 0.5f), 1));
                boxesInner.Add(new Box(new Vector3(-8f, 10f, 0.5f), 1));



                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0, 4f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(6f, -8f, 0.5f), true, new Vector3(6f, 1f, 1f), true));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-5f, 0f, 0.5f), true, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 50f;

                levelStyle = "Purple";

                isLevelReversed = true;

                break;

            case 15:
                boxesInner.Add(new Box(new Vector3(-8f, 9f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-8f, 3f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-10f, -14f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-8f, -1f, 0.5f), 20));


                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, 2f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-1f, -3, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -8f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Purple";

                isLevelReversed = true;

                break;

            case 16:
                boxesInner.Add(new Box(new Vector3(0f, -10f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(6.5f, 8f, 0.5f), 20));
                boxesInner.Add(new Box(new Vector3(-5.5f, 8f, 0.5f), 20));

                obstaclePositions.Add(new Vector3(6.5f, 11f, 0.5f));
                obstaclePositions.Add(new Vector3(-5.5f, 11f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(6f, 0, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-5f, 0, 0.5f), false, new Vector3(6f, 1f, 1f), false));


                ballCount = 600;

                cameraScale = 37f;

                levelStyle = "Purple";

                isLevelReversed = true;

                break;

        }
        

        boxes = boxesInner;
        rotatingObjects = rotatingObjectsInner;
    }
}
