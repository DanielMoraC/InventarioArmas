using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecciondeStats : MonoBehaviour {

    Inventory invequip;

    private bool Verde;

    public GameObject[] Guantes;

    int i;

    public int damage;
    public int damagez;

    // Use this for initialization
    void Start () {
        invequip = GameObject.FindWithTag("GameController").GetComponent<Inventory>();
        Guantes = GameObject.FindGameObjectsWithTag("item");

        for (i = 0; i < Guantes.Length; i++)
        {
            //Debug.Log("Item Number " + i + " is named " + Guantes[i].name);
        }
    }
	
	// Update is called once per frame
	void Update () {
        
        if (i == 0)
        {
            damage = 100;
            damagez = 150;
        }
    }
}
