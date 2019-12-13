using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    float limitUp = 35;
    float limitDown = -15;
    int points = 5;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameController.actualPoints += points;        
        Debug.Log("Mis puntos son " + GameController.actualPoints);

        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > limitUp)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < limitDown)
        {
            Destroy(gameObject);
            GameController.life--;
            Debug.Log("Tengo " + GameController.life + " vidas");
        }
    }
}
