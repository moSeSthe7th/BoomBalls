using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Material ballMat;
    public Material basketMat;
    public Material backgroundPlaneMat;
    public Material rotatingObjectMat;
    public Material ballShooterMat;

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
                backgroundPlaneMat.color = Color.white;
                rotatingObjectMat.color = new Color(1f, 0.4386792f, 0.4386792f);
                ballShooterMat.color = new Color(1f, 0.4386792f, 0.4386792f);

                ballMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(1f, 0, 0));

                DataScript.textColor = new Color(1f, 0.3254717f, 0.3254717f);

                uIScript.InitializeUI("Red");

                break;

            case "Orange":

                ballMat.color = new Color(0.8784314f, 0.5982618f, 0.3254901f);
                basketMat.color = new Color(1f, 0.6322619f, 0.4392157f);
                // alternate basketMat.color = new Color(0.3601535f, 0.3962264f, 0.1812923f);
                backgroundPlaneMat.color = Color.white;
                rotatingObjectMat.color = new Color(1f, 0.6322619f, 0.4392157f);
                ballShooterMat.color = new Color(1f, 0.6322619f, 0.4392157f);

                ballMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(2f, 0, 0));
                //alternate basketMat.SetColor("_EmissionColor", new Color(0.7604733f, 0.2221288f, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(2f, 0, 0));

                DataScript.textColor = new Color(1f, 0.6369535f, 0.3254902f);

                uIScript.InitializeUI("Orange");

                break;

            case "Yellow":

                ballMat.color = new Color(1f, 0.9522471f, 0f);
                basketMat.color = new Color(1f, 0.95381f, 0);
                backgroundPlaneMat.color = Color.white;
                rotatingObjectMat.color = new Color(1f, 0.95381f, 0);
                ballShooterMat.color = new Color(1f, 0.95381f, 0);

                ballMat.SetColor("_EmissionColor", new Color(0.5f, 0.01372549f, 0.01372549f));
                basketMat.SetColor("_EmissionColor", new Color(1.148698f, 0.2702682f, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(1.148698f, 0.2702682f, 0));

                DataScript.textColor = new Color(1f, 0.9305689f, 0.3254902f);

                uIScript.InitializeUI("Yellow");

                break;

            case "Green":

                ballMat.color = new Color(0.2593894f, 0.8207547f, 0.397723f);
                basketMat.color = new Color(0.2122642f, 1f, 0.4382399f);
                backgroundPlaneMat.color = Color.white;
                rotatingObjectMat.color = new Color(0.2122642f, 1f, 0.4382399f);
                ballShooterMat.color = new Color(0.2122642f, 1f, 0.4382399f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                DataScript.textColor = new Color(0.3254902f, 1f, 0.4435614f);

                uIScript.InitializeUI("Green");

                break;

            case "Blue":

                ballMat.color = new Color(0.2588235f, 0.7478982f, 0.8196079f);
                basketMat.color = new Color(0.2117647f, 0.8737545f, 1f);
                backgroundPlaneMat.color = Color.white;
                rotatingObjectMat.color = new Color(0.2117647f, 0.8737545f, 1f);
                ballShooterMat.color = new Color(0.2117647f, 0.8737545f, 1f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                DataScript.textColor = new Color(0.3254902f, 0.8207444f, 1f);

                uIScript.InitializeUI("Blue");

                break;

            case "Purple":

                ballMat.color = new Color(0.8195439f, 0.3160377f, 1f);
                basketMat.color = new Color(0.7604855f, 0.2117647f, 1f);
                backgroundPlaneMat.color = Color.white;
                rotatingObjectMat.color = new Color(0.7604855f, 0.2117647f, 1f);
                ballShooterMat.color = new Color(0.7604855f, 0.2117647f, 1f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                DataScript.textColor = new Color(0.9824958f, 0.3254902f, 1f);

                uIScript.InitializeUI("Purple");

                break;

            case "Pink":

                ballMat.color = new Color(1f, 0.3160377f, 0.5782819f);
                basketMat.color = new Color(1f, 0.4764151f, 0.6736003f);
                backgroundPlaneMat.color = Color.white;
                rotatingObjectMat.color = new Color(1f, 0.4764151f, 0.6736003f);
                ballShooterMat.color = new Color(1f, 0.4764151f, 0.6736003f);

                ballMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                basketMat.SetColor("_EmissionColor", new Color(0, 0, 0));
                rotatingObjectMat.SetColor("_EmissionColor", new Color(0, 0, 0));

                DataScript.textColor = new Color(1f, 0.4009434f, 0.8860744f);

                uIScript.InitializeUI("Pink");

                break;
        }
        
    }
}


//rotatingObjectMat.color = new Color(1f, 0.5945601f, 4392157f);
//rotatingObjectMat.SetColor("_EmissionColor", new Color(1f, 0.06387119f, 0));              good for purple
