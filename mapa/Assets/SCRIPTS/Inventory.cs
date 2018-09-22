using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //The parent of invItems and invequ
    public GameObject invmenu;
    //Where the items are stored
    public GameObject invItems;
    //Where the item is equiped
    public GameObject invequ;

    //noting really important
    public GameObject potiv;
    public GameObject potivpivote;
    public GameObject potim;
    public GameObject potimpivote;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            invmenu.SetActive(true);
        }
        else
        {
            invmenu.SetActive(false);
        }


        //I'm testing things but they aren't working
        string Name = invequ.transform.Find("ChildName").gameObject.name;

        //Debug.Log("Equipped item name: " + invequ.GetComponentInChildren<>); transform.FindChild("nameOfChildObject")
        //Debug.Log(invequ = GetComponentInChildren<PropertyName>();
        //invequ.transform.GetChild();

    }
    
    
}
