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
    PickUp tope;

    //private bool Verde;

    //public GameObject[] Guantes;



    // Use this for initialization
    void Start () {
        invequip= GameObject.FindWithTag("GameController").GetComponent<Inventory>();
        tope = GameObject.FindWithTag("GameController").GetComponent<PickUp>();

    }
	
	// Update is called once per frame
	void Update () {
        /*if (Pasado)
        {
            GetComponent<Button>().onClick.AddListener(() => Equip());
        }*/
	}

    public void Pasar()
    {
        if (Equipado && tope.maximo < 15)
        {
            icono.transform.SetParent(invequip.invItems.transform);
            //Pasado = true;
            Equipado = false;
            //GetComponent<Button>().onClick.AddListener(Equip);
        }

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
    }
    public void Stats()
    {/*
        if (Verde)
        {
            icono.transform.SetParent(invequip.invItems.transform);
            Equipado = false;
        }*/
        
    }

}
