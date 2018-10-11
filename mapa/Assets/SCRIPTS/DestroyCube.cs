using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour {

    public GameObject player;
    Rigidbody m_Rigidbody;

    static public GameObject cub;

    // Use this for initialization
    void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {/*
        if (Input.GetKeyDown(KeyCode.E) && Teletransport.posible)
        {
            player.transform.position = gameObject.transform.position;
            Destroy(gameObject, 0);
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pared")
        {
            Debug.Log("Hola");
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX;
        }
    }/*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pared")
        {
            Debug.Log("Hola");
        }
    }*/
}
