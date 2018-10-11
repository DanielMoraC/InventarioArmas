using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpVerde : MonoBehaviour
{

    Inventory invScript;
    PickUp tope;
    EquipItem a;
    Matar u;


    public bool item;
    public GameObject itemIcon;

    public bool pickedUp = false;

    public int damage = 100;
    public int damageM = 100;
    public int damageV = 100;
    public int damageZ = 150;

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
            if (Input.GetKeyDown(KeyCode.F) && !pickedUp && tope.maximo <15)
            {
                if (item)
                {
                    GameObject i = Instantiate(itemIcon);
                    i.transform.SetParent(invScript.invItems.transform);
                    gameObject.SetActive(false);
                    tope.maximo++;
                }

            }
        }

    }
}