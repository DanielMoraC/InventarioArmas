using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SePuede : MonoBehaviour {


    EquipItem hola;

	// Use this for initialization
	void Start () {
        hola = GameObject.FindWithTag("item").GetComponent<EquipItem>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
