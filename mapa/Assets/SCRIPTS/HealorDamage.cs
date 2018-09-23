using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealorDamage : MonoBehaviour {

    public bool isDamaging;
    public bool isDamagingP;
    static public float heal = 10;
    static public float damage = 10;
    static public float damageP = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        /*
        if (other.tag == "Player")
        {
            other.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
        }*/

        if (other.tag == "Player"&&isDamaging)
        {
            other.SendMessage("TakeDamage");
            
        }else if (other.tag == "Player" && isDamagingP)
        {
            other.SendMessage("TakeDamageP", Time.deltaTime * damageP);
        }
        else if (other.tag == "Player" && !isDamaging)
        {
            other.SendMessage("HealDamage");
        }
    }
}
