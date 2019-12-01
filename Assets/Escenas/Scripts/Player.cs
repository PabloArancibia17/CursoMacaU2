using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float horizontalMovement;
    public float speed = 10;
    public float limitX = 10;
    public GameObject [] comida;
    int random;
    int minPrefab = 0, maxPrefab = 3;

   
    void Update()
    {
        #region Movimiento
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.Translate(horizontalMovement * speed * Time.deltaTime * Vector3.right);

        if(transform.position.x < -limitX)
        {
            transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
        }

        if (transform.position.x > limitX)
        {
            transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        }
        #endregion

        if (Input.GetKeyDown(KeyCode.Space))
        {
            random = Random.Range(minPrefab, maxPrefab);
            Instantiate(comida[random], transform.position, transform.rotation);            
        }
    }
}
