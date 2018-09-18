using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipItem : MonoBehaviour {


    public bool Equipado;
    public Button X;
    public Button Obj;
    public GameObject icono;

    Inventory invequip;

    

    // Use this for initialization
    void Start () {
        invequip= GameObject.FindWithTag("GameController").GetComponent<Inventory>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Equip()
    {
        if (!Equipado)
        {
            icono.transform.SetParent(invequip.invequ.transform);
            Equipado = true;
        }
        
    }
    public void RemoveButton()
    {
        if (Equipado)
        {
            icono.transform.SetParent(invequip.invItems.transform);
            Equipado = false;
        }
        else if (!Equipado)
        {
            Destroy(icono, 0);
        }
        //Inventory..Remove(itemIcon);
    }
}
