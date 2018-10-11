using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cofre : MonoBehaviour {

    Inventory invScript;
    PickUp tope;

    static public bool openeded = false;

    public bool pickedUp = false;

    public GameObject Objetos;

    // Use this for initialization
    void Start()
    {
        invScript = GameObject.FindWithTag("GameController").GetComponent<Inventory>();
        tope = GameObject.FindWithTag("GameController").GetComponent<PickUp>();
    }
    void Update()
    {

    }

    // Update is called once per frame

    void OnTriggerStay(Collider player)
    {
        if (player.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                invScript.invmenu.SetActive(true);
                Objetos.SetActive(true);
                openeded = true;
            }
            else
            {
                invScript.invmenu.SetActive(false);
                Objetos.SetActive(false);
                openeded = false;
                
            }
            
        }

    }

}
