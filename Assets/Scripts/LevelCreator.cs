using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCreator : MonoBehaviour
{
    public GameObject rotatingObject;
    public GameObject box;
    public GameObject obstacle;

    private LevelData levelData;
    private ColorScript colorScript;
    private InGameBallCounterScript counterScript;

    public List<LevelData.Box> boxes;
    public List<LevelData.RotatingObject> rotatingObjects;
    private List<Vector3> obstaclePositions;

    void Start()
    {
        levelData = FindObjectOfType(typeof(LevelData)) as LevelData;
        colorScript = FindObjectOfType(typeof(ColorScript)) as ColorScript;
        counterScript = FindObjectOfType(typeof(InGameBallCounterScript)) as InGameBallCounterScript;

        CreateLevel();
    }

   

    private void CreateLevel()
    {
        levelData.LoadLevelData(DataScript.currentLevel);

        colorScript.ColorizeTheLevel(levelData.levelStyle);
        rotatingObjects = levelData.rotatingObjects;
        boxes = levelData.boxes;
        obstaclePositions = levelData.obstaclePositions;
        DataScript.ballCount = levelData.ballCount;
        counterScript.SetInGameBallCounter();

        for (int i = 0; i< boxes.Count; i++)
        {
            DataScript.boxCountInLevel += 1;

            GameObject currentBox = Instantiate(box, boxes[i].position, box.transform.rotation);
            HitBoxScript hitBoxScript = currentBox.GetComponent<HitBoxScript>();
            hitBoxScript.count = boxes[i].count;
            Text text = currentBox.GetComponentInChildren<Text>();
            text.text = boxes[i].count.ToString();
            //currentBox.transform.rotation = new Quaternion(0f, 180f, 0f,0f);
        }

        for(int i = 0; i < rotatingObjects.Count; i++)
        {
            GameObject currentRotatingObj = Instantiate(rotatingObject, rotatingObjects[i].position, Quaternion.identity);
            currentRotatingObj.transform.localScale = rotatingObjects[i].scale;
            currentRotatingObj.GetComponent<RotatingObjectScript>().isTrampoline = rotatingObjects[i].isTrampoline;
            currentRotatingObj.GetComponent<RotatingObjectScript>().isTrampolinedToRight = rotatingObjects[i].isTrampolinedRight;
        }

        for(int i = 0; i<obstaclePositions.Count; i++)
        {
            Instantiate(obstacle, obstaclePositions[i],Quaternion.identity);
        }
    }
}
