using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static int life = 3;
    public static int actualPoints = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (actualPoints == 100)
        {
            Debug.Log("You Win");
        }

        if (life == 0)
        {
            Debug.Log("You Lose");
        }
    }
}
