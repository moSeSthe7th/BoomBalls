using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Material ballMat;
    public Material basketMat;
    public Material backgroundPlaneMat;
    public Material rotatingObjectMat;

    private UIScript uIScript;

    private void Start()
    {
        uIScript = FindObjectOfType(typeof(UIScript)) as UIScript;
    }

    public void ColorizeTheLevel(string levelStyle)
    {
        switch (levelStyle)
        {
            case "Red":

                ballMat.color = new Color(0.8773585f, 0.3269402f, 0.3884576f);
                basketMat.color = new Color(1f, 0.4386792f, 0.4386792f);
                backgroundPlaneMat.color = new Color(1, 0.3632075f, 0.3632075f);
                rotatingObjectMat.color = new Color(1f, 0.4386792f, 0.4386792f);

                ballMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(1f, 0, 0));

                uIScript.InitializeUI("Red");

                break;

            case "Orange":

                ballMat.color = new Color(0.8784314f, 0.5982618f, 0.3254901f);
                basketMat.color = new Color(1f, 0.6322619f, 0.4392157f);
                // alternate basketMat.color = new Color(0.3601535f, 0.3962264f, 0.1812923f);

                backgroundPlaneMat.color = new Color(1, 0.5306181f, 0.2971698f);
                rotatingObjectMat.color = new Color(1f, 0.6322619f, 0.4392157f);

                ballMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                //alternate basketMat.SetColor("_EmissionColor", new Color(0.7604733f, 0.2221288f, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(2f, 0, 0));

                uIScript.InitializeUI("Orange");

                break;

            case "Yellow":

                ballMat.color = new Color(1f, 0.9522471f, 0f);
                basketMat.color = new Color(1f, 0.95381f, 0);
                backgroundPlaneMat.color = new Color(0.2588235f, 1f, 0.355665f);
                rotatingObjectMat.color = new Color(1f, 0.95381f, 0);

                ballMat.SetColor("_EmissionColor", new Color(0.5f, 0.01372549f, 0.01372549f));
                basketMat.SetColor("_EmissionColor", new Color(1.148698f, 0.2702682f, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(1.148698f, 0.2702682f, 0));

                uIScript.InitializeUI("Yellow");

                break;

            case "Green":

                ballMat.color = new Color(0.2593894f, 0.8207547f, 0.397723f);
                basketMat.color = new Color(0.2122642f, 1f, 0.4382399f);
                backgroundPlaneMat.color = new Color(0.2971698f, 1f, 0.4110586f);
                rotatingObjectMat.color = new Color(0.2122642f, 1f, 0.4382399f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                uIScript.InitializeUI("Green");

                break;

            case "Blue":

                ballMat.color = new Color(0.2588235f, 0.7478982f, 0.8196079f);
                basketMat.color = new Color(0.2117647f, 0.8737545f, 1f);
                backgroundPlaneMat.color = new Color(0.1509434f, 0.4921775f, 0.6037736f);
                rotatingObjectMat.color = new Color(0.2117647f, 0.8737545f, 1f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                uIScript.InitializeUI("Blue");

                break;

            case "Purple":

                ballMat.color = new Color(0.8195439f, 0.3160377f, 1f);
                basketMat.color = new Color(0.7604855f, 0.2117647f, 1f);
                backgroundPlaneMat.color = new Color(0.6792453f, 0.4069064f, 0.625931f);
                rotatingObjectMat.color = new Color(0.7604855f, 0.2117647f, 1f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                uIScript.InitializeUI("Purple");

                break;

            case "Pink":

                ballMat.color = new Color(1f, 0.3160377f, 0.5782819f);
                basketMat.color = new Color(1f, 0.4764151f, 0.6736003f);
                backgroundPlaneMat.color = new Color(0.9716981f, 0.5087665f, 0.6671286f);
                rotatingObjectMat.color = new Color(1f, 0.4764151f, 0.6736003f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                uIScript.InitializeUI("Pink");

                break;
        }
        
    }
}


//rotatingObjectMat.color = new Color(1f, 0.5945601f, 4392157f);
//rotatingObjectMat.SetColor("_EmissionColor", new Color(1f, 0.06387119f, 0));              good for purple
