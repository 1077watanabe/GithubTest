using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public float speed = 15f;
    void FixedUpdate() {
        var velox = speed * Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(velox, 0f, 0f); }
    
    }