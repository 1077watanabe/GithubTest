using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float bounce = 6.0f;
    public int scorepoint = 10;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Vector3 norm = other.contacts[0].normal;
            Vector3 vel = new Vector3(-norm.x, 0f, -norm.z);
            other.rigidbody.AddForce(vel.normalized * bounce, ForceMode.VelocityChange);
            // Update is called once per frame
            GameObject gm = GameObject.Find("GameManager");
            gm.GetComponent<GameManager>().AddScore(scorepoint);
        }
    }
}
