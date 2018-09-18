using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject invItems;
    public GameObject invmenu;
    public GameObject invequ;
    public GameObject potiv;
    public GameObject potivpivote;
    public GameObject potim;
    public GameObject potimpivote;

    public bool a = false;


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
            //Time.timeScale = 0;
        }
        else
        {
            invmenu.SetActive(false);
            //Time.timeScale = 1;
        }

        //Debug.Log(invequ.GetComponentsInChildren<PropertyName>);
        //Debug.Log("Objeto equipado nombre: " + invequ.GetComponentInChildren<>); transform.FindChild("nameOfChildObject")
        Debug.Log(invequ = GetComponentInChildren<name>();

    }
    
    /*
    public void OnApplicationPause(bool pause)
    {
        
    }*/
}
