using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float rotAngle = 4.0f;
    private void FixedUpdate()
    {
        transform.Rotate(0f, rotAngle, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
