using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 10f;
    private float timedestroy=2;
    
    void Start()
    {
   
            
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
     
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            Debug.Log("dan enemy");
            Destroy(gameObject);
        }
    
    }

}
