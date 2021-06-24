using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Destroy(gameObject, 0.2f);        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
