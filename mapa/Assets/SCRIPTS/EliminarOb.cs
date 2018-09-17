using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EliminarOb : MonoBehaviour {


    public Button X;
    public GameObject icono;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RemoveButton()
    {
        //Inventory..Remove(itemIcon);
        Destroy(icono, 0);
    }
}
