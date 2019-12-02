using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarAnimales : MonoBehaviour
{

    //public GameObject [] animales = new GameObject [3];
    public GameObject []animales = new GameObject[2];
    public int maxAnimals;
    public int countAnimals = 1;
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (canInstantiate)
        {
            StartCoroutine(InstantiateAnimals());
        }
    }

    bool canInstantiate = true;
    IEnumerator InstantiateAnimals()
    {
             
        Instantiate(animales[Random.Range(0,2)], new Vector3(transform.position.x + Random.Range(-9, 9), transform.position.y, transform.position.z), transform.rotation, transform.parent);

        canInstantiate = false;

        yield return new WaitForSeconds(3);

        canInstantiate = true;
       
        
    }  

    
}
