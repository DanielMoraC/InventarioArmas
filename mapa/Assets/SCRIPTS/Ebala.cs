using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ebala : MonoBehaviour {

    Rigidbody rb;
    public float BulletSpeed;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(0, 0, BulletSpeed, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject,0);
        }
    }
}
