using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public List<Box> boxes;
    public List<RotatingObject> rotatingObjects;
    public List<Whirlwind> whirlwinds;

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
        public bool isMovingVertical;
        public bool isMovingHorizontal;

        public Box(Vector3 pos, int cnt, bool ismovingvertical, bool ismovinghorizontal)
        {
            this.position = pos;
            this.count = cnt;
            this.isMovingHorizontal = ismovinghorizontal;
            this.isMovingVertical = ismovingvertical;
        }
    }

    public struct Whirlwind
    {
        public Vector3 position;
        public bool isRotatingClockwise;
        public float rotatingSpeed;
        public float delay;

        public Whirlwind(Vector3 pos, bool isClockwise,float rotatingSpeed, float delay)
        {
            this.isRotatingClockwise = isClockwise;
            this.position = pos;
            this.delay = delay;
            this.rotatingSpeed = rotatingSpeed;
        }
    }

    public void LoadLevelData(int levelNumber)
    {
        List<Box> boxesInner = new List<Box>();
        List<RotatingObject> rotatingObjectsInner = new List<RotatingObject>();
        List<Whirlwind> whirlwindsInner = new List<Whirlwind>();

        switch (levelNumber)
        {

            case 1:
                //cok kolay
                boxesInner.Add(new Box(new Vector3(-5f, 9f, 0.5f), 16, false, false));
                boxesInner.Add(new Box(new Vector3(-5f, 3f, 0.5f), 17, false, false));
                boxesInner.Add(new Box(new Vector3(-5f, -12f, 0.5f), 15, false, false));
                boxesInner.Add(new Box(new Vector3(-5f, -1f, 0.5f), 18, false, false));

                obstaclePositions.Add(new Vector3(-7f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(-5f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(-3f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(-1f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(1f, 12f, 0.5f));



                rotatingObjectsInner.Add(new RotatingObject(new Vector3(5f, 2f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -3, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-1f, -8f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 100;

                cameraScale = 37f;

                levelStyle = "Red";

                isLevelReversed = false;

                break;

            case 2:
                //kolay level
                boxesInner.Add(new Box(new Vector3(8f, 6f, 0.5f), 3, false, false));
                boxesInner.Add(new Box(new Vector3(2f, -14f, 0.5f), 6, false, false));
                boxesInner.Add(new Box(new Vector3(-8f, 10f, 0.5f), 3, false, false));

                obstaclePositions.Add(new Vector3(8f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 12f, 0.5f));


                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0, 4f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(6f, -8f, 0.5f), true, new Vector3(6f, 1f, 1f), true));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-5f, 0f, 0.5f), true, new Vector3(6f, 1f, 1f), false));

                ballCount = 20;

                cameraScale = 37f;

                levelStyle = "Red";

                isLevelReversed = false;

                break;


            case 3:
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 8,false,false));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 4,false,false));
                boxesInner.Add(new Box(new Vector3(6f, -10f, 0.5f), 8,false,false));
                boxesInner.Add(new Box(new Vector3(8f, 4f, 0.5f), 4, false, false));

                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0f, 0f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 40;

                cameraScale = 37f;

                levelStyle = "Red";

                isLevelReversed = false;

                break;

            case 4:
                boxesInner.Add(new Box(new Vector3(8f, 0, 0.5f), 8, false, false));
                boxesInner.Add(new Box(new Vector3(-8f, 0, 0.5f), 4, false, false));
                boxesInner.Add(new Box(new Vector3(8f, -9f, 0.5f), 8, false, false));

                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(2f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(3f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(4f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(5f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-3f, 4f, 0.5f), false, new Vector3(10f, 1f, 1f), false));

                ballCount = 40;

                cameraScale = 37f;

                levelStyle = "Purple";

                isLevelReversed = false;

                break;

            case 5:
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 5, false, false));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 5, false, false));
                boxesInner.Add(new Box(new Vector3(-3f, -10f, 0.5f), 5, false, false));
                boxesInner.Add(new Box(new Vector3(8f, -10f, 0.5f), 5, false, false));
                boxesInner.Add(new Box(new Vector3(8f, -2f, 0.5f), 5, false, false));

                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(4f, -4f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 40;

                cameraScale = 37f;

                levelStyle = "Purple";

                isLevelReversed = false;

                break;
                
            case 6:
               
                boxesInner.Add(new Box(new Vector3(3f, 3f, 0.5f), 3, false, false));
                boxesInner.Add(new Box(new Vector3(5f, -14f, 0.5f), 6, false, false));
                boxesInner.Add(new Box(new Vector3(0, -12f, 0.5f), 6, false, false));

                obstaclePositions.Add(new Vector3(0, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(4.5f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(-2f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(2f, 12f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 12f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(8f, -8f, 0.5f), true, new Vector3(4f, 1f, 1f), true));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -5f, 0.5f), true, new Vector3(4f, 1f, 1f), true));
                

                obstaclePositions.Add(new Vector3(-4f, 3f, 0.5f));



                ballCount = 35;

                cameraScale = 37f;

                levelStyle = "Purple";

                isLevelReversed = false;

                break;

            case 7:
                // biraz zor bi level 9 yapabiliriz...
                boxesInner.Add(new Box(new Vector3(-5f, -13f, 0.5f), 2, false, false));
                boxesInner.Add(new Box(new Vector3(-8f, 12f, 0.5f), 7, false, false));
                boxesInner.Add(new Box(new Vector3(8f, 7f, 0.5f), 5, false, false));
                boxesInner.Add(new Box(new Vector3(7f, -14f, 0.5f), 2, false, false));
                boxesInner.Add(new Box(new Vector3(8f, 0f, 0.5f), 5, false, false));
                boxesInner.Add(new Box(new Vector3(-8f, 3f, 0.5f), 2, false, false));

                obstaclePositions.Add(new Vector3(8f, 14f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 14f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 14f, 0.5f));
                obstaclePositions.Add(new Vector3(-6f, 14f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 14f, 0.5f));
                obstaclePositions.Add(new Vector3(-2f, 14f, 0.5f));
                obstaclePositions.Add(new Vector3(-5f, -5f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, 5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -2f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -12f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 50;

                cameraScale = 43f;

                levelStyle = "Green";

                isLevelReversed = false;

                break;


            case 8:
                //hareketlilerin ilk bölümü
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 3, true, false));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 3, false, true));
                boxesInner.Add(new Box(new Vector3(6f, -10f, 0.5f), 3, true, false));
                boxesInner.Add(new Box(new Vector3(8f, 4f, 0.5f), 3, false, true));

                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0f, 0f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                ballCount = 13;

                cameraScale = 37f;

                levelStyle = "Green";

                isLevelReversed = false;

                break;

            

            case 9:
                //zor
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 5, true, false));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 5, false, true));
                boxesInner.Add(new Box(new Vector3(-3f, -11f, 0.5f), 3, true, false));
                boxesInner.Add(new Box(new Vector3(8f, -10f, 0.5f), 2, false, true));
                boxesInner.Add(new Box(new Vector3(8f, -2f, 0.5f), 2, false, false));

                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-2f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(0, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(4f, -4f, 0.5f), true, new Vector3(6f, 1f, 1f), false));

                ballCount = 13;

                cameraScale = 37f;

                levelStyle = "Green";

                isLevelReversed = false;

                break;

            

            case 10:
                //zor +1
                boxesInner.Add(new Box(new Vector3(-5f, -13f, 0.5f), 3, false, true));
                boxesInner.Add(new Box(new Vector3(-8f, 10f, 0.5f), 3, true, false));
                boxesInner.Add(new Box(new Vector3(8f, 7f, 0.5f), 2, true, false));
                boxesInner.Add(new Box(new Vector3(7f, 0f, 0.5f), 2, false, true));
                boxesInner.Add(new Box(new Vector3(-7f, 3f, 0.5f), 3, false, true));

                obstaclePositions.Add(new Vector3(-6f, 13.5f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 13.5f, 0.5f));
                obstaclePositions.Add(new Vector3(-2f, 13.5f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 13.5f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 13.5f, 0.5f));
                obstaclePositions.Add(new Vector3(8f, 13.5f, 0.5f));

                obstaclePositions.Add(new Vector3(-5f, -5f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, 5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-4f, -2f, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(2f, -12f, 0.5f), true, new Vector3(6f, 1f, 1f), true));

                ballCount = 25;

                cameraScale = 43f;

                levelStyle = "Blue";

                isLevelReversed = false;

                break;

            case 11:
                //zor kaliteli
                boxesInner.Add(new Box(new Vector3(0f, -10f, 0.5f), 6, false, false));
                boxesInner.Add(new Box(new Vector3(6.5f, 8f, 0.5f), 5, false, false));
                boxesInner.Add(new Box(new Vector3(-5.5f, 8f, 0.5f), 5, false, false));

                obstaclePositions.Add(new Vector3(6.5f, 11f, 0.5f));
                obstaclePositions.Add(new Vector3(-5.5f, 11f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(6f, 0, 0.5f), false, new Vector3(6f, 1f, 1f), false));
                rotatingObjectsInner.Add(new RotatingObject(new Vector3(-5f, 0, 0.5f), false, new Vector3(6f, 1f, 1f), false));


                ballCount = 7;

                cameraScale = 37f;

                levelStyle = "Blue";

                isLevelReversed = false;

                break;

            case 12:
                boxesInner.Add(new Box(new Vector3(-1f, -14f, 0.5f), 2, false, false));
                boxesInner.Add(new Box(new Vector3(-8f, 5f, 0.5f), 2, false, false));


                rotatingObjectsInner.Add(new RotatingObject(new Vector3(5f, -5f, 0.5f), false, new Vector3(6f, 1f, 1f), false));


                whirlwindsInner.Add(new Whirlwind(new Vector3(-3f, 8f, 0.5f), false, 1f, 0));

                ballCount = 5;

                cameraScale = 37f;

                levelStyle = "Blue";

                isLevelReversed = false;

                break;

            case 13:
                boxesInner.Add(new Box(new Vector3(-5f, -12f, 0.5f), 2, false, false));
                boxesInner.Add(new Box(new Vector3(5f, 8f, 0.5f), 5, false, false));


                obstaclePositions.Add(new Vector3(0f, 15f, 0.5f));
                obstaclePositions.Add(new Vector3(-1f, 15f, 0.5f));
                obstaclePositions.Add(new Vector3(-2f, 15f, 0.5f));
                obstaclePositions.Add(new Vector3(-3f, 15f, 0.5f));
                obstaclePositions.Add(new Vector3(-4f, 15f, 0.5f));
                obstaclePositions.Add(new Vector3(-5f, 15f, 0.5f));
                obstaclePositions.Add(new Vector3(-6f, 15f, 0.5f));
                obstaclePositions.Add(new Vector3(-7f, 15f, 0.5f));


                whirlwindsInner.Add(new Whirlwind(new Vector3(0, 8f, 0.5f), false,1f,0));
                whirlwindsInner.Add(new Whirlwind(new Vector3(5f, 1f, 0.5f), true,1f,0));
                whirlwindsInner.Add(new Whirlwind(new Vector3(0, -7f, 0.5f), false,0.5f,2f));

                ballCount = 5;

                cameraScale = 43f;

                levelStyle = "Orange";

                isLevelReversed = false;

                break;
                
            case 14:
                //BONUS LEVEL
                DataScript.isBonusLevel = true;
                
                boxesInner.Add(new Box(new Vector3(-6f, -10f, 0.5f), 1, true, false));
                boxesInner.Add(new Box(new Vector3(-8f, 4f, 0.5f), 1, false, false));
                boxesInner.Add(new Box(new Vector3(6f, -10f, 0.5f), 1, true, true));
                boxesInner.Add(new Box(new Vector3(8f, 4f, 0.5f), 1, false, true));

                obstaclePositions.Add(new Vector3(-6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-8f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(-5f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(5f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(6f, 8f, 0.5f));
                obstaclePositions.Add(new Vector3(8f, 8f, 0.5f));

                rotatingObjectsInner.Add(new RotatingObject(new Vector3(0f, 0f, 0.5f), false, new Vector3(6f, 1f, 1f), false));

                whirlwindsInner.Add(new Whirlwind(new Vector3(0, 8f, 0.5f), false, 2f, 0));

                ballCount = 50;

                cameraScale = 37f;

                levelStyle = "Orange";

                isLevelReversed = true;

                break;

        }
        

        boxes = boxesInner;
        rotatingObjects = rotatingObjectsInner;
        whirlwinds = whirlwindsInner;
    }
}
