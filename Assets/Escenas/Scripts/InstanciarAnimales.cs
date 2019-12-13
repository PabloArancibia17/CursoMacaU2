using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarAnimales : MonoBehaviour
{

    //public GameObject [] animales = new GameObject [3];
    public GameObject []animales = new GameObject[2];
    public int maxAnimals;
    public int countAnimals = 1;
    public int delayOfInstantiate = 3;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(InstantiateObject), 0, delayOfInstantiate);
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    void InstantiateObject()
    {
        Instantiate(animales[Random.Range(0, 2)], new Vector3(transform.position.x + Random.Range(-9, 9), transform.position.y, transform.position.z), transform.rotation, transform.parent);

    }



}
