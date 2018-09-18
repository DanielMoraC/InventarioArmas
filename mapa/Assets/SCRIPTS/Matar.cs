using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour {


    Stats Estadisticas;
    EquipItem Eq;

    public GameObject Zombie;
    public GameObject Bala;

    PickUpVerde guanteverde;

    public int daño;
    public int dañozombie;
    public int dañomomia;
    public int dañovampiro;

    // Use this for initialization
    void Start () {
        Estadisticas = GameObject.FindWithTag("GameController").GetComponent<Stats>();
        guanteverde = GameObject.FindWithTag("GameController").GetComponent<PickUpVerde>();
    }
	
	// Update is called once per frame
	void Update () {

	}
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bala")
        {
            Debug.Log("Hola");
            Destroy(Zombie, 0);
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            Debug.Log("Hola");
            Destroy(Zombie, 0);
        }
    }*/
}
