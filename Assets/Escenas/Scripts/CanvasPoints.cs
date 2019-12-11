using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPoints : MonoBehaviour
{

    public Text points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        points.text = ("POINTS: " + GameController.actualPoints.ToString());
        if (GameController.actualPoints >= 100)
        {
            points.text = ("YOU WIN");
        }

        if (GameController.life <= 0)
        {
            points.text = ("YOU LOSE");
        }
    }

}
