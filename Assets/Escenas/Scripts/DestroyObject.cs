using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float limitUp;
    public float limitDown;

    private void OnTriggerEnter(Collider other)
    {
             
                    
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 30)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -15)
        {
            Destroy(gameObject);
        }
    }
}
