using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    public int damage;
    public int damageM;
    public int damageV;
    public int damageZ;

    PickUpVerde guanteverde;
    // Use this for initialization
    void Start () {
        guanteverde = GameObject.FindWithTag("GameController").GetComponent<PickUpVerde>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
