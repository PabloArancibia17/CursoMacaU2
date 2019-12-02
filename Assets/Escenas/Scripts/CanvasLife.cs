using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasLife : MonoBehaviour
{

    public Text life;

    // Update is called once per frame
    void Update()
    {
        life.text = ("VIDAS: " + GameController.life.ToString());
    }
}
