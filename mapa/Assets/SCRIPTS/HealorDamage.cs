using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealorDamage : MonoBehaviour {

    public bool isDamaging;
    public float damage = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
        }
    }
}
