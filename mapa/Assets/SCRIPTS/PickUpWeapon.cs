﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWeapon : MonoBehaviour {

    Inventory invScript;


    public bool item;
    public GameObject itemIcon;

    public bool pickedUp = false;

    int maximo = 0;


    // Use this for initialization
    void Start()
    {
        invScript = GameObject.FindWithTag("GameController").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider player)
    {
        if (player.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F) && !pickedUp && maximo < 15)
            {
                if (item)
                {
                    GameObject i = Instantiate(itemIcon);
                    i.transform.SetParent(invScript.invItems.transform);
                    //Destroy(gameObject);
                    maximo++;
                }

            }
        }

    }
}
