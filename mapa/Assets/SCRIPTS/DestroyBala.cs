using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBala : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider player)
    {
        if (player.tag == "pared")
        {
            Destroy(gameObject, 0);
        }

    }
}
