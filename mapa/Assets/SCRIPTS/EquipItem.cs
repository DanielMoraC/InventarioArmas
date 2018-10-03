using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipItem : MonoBehaviour {


    public bool Equipado;
    public Button X;
    public Button Obj;
    public GameObject icono;
    public GameObject iconoCofre;

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
    /*
    public void Pasar()
    {
        if (Equipado && tope.maximo < 15)
        {
            icono.transform.SetParent(invequip.invItems.transform);
            //Pasado = true;
            Equipado = false;
            //GetComponent<Button>().onClick.AddListener(Equip);
        }

    }*/
    public void Pasar()
    {
        if (tope.maximo < 15)
        {
            icono.SetActive(true);
            icono.transform.SetParent(invequip.invItems.transform);            
            Destroy(iconoCofre, 0);
            //iconoCofre.SetActive(false);
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
            //DestroyImmediate(icono, true);
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
