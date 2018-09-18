using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour {


    Stats Estadisticas;
    EquipItem Eq;

    public GameObject Zombie;

	// Use this for initialization
	void Start () {
        Estadisticas = GameObject.FindWithTag("GameController").GetComponent<Stats>();
    }
	
	// Update is called once per frame
	void Update () {

	}
    
    private void OnCollisionEnter(Collider colli)
    {
        if (colli.gameObject.tag == "Zombie")
        {
            Debug.Log("Hola");
            Destroy(Zombie,0);
        }
        
    }/*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            Debug.Log("Hola");
            Destroy(Zombie, 0);
        }
    }*/
}
