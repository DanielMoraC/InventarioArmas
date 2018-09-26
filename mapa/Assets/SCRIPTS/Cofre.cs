using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cofre : MonoBehaviour {

    Inventory invScript;
    PickUp tope;

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
            if (Input.GetKey(KeyCode.E))
            {
                invScript.invmenu.SetActive(true);
                Objetos.SetActive(true);
                //DontLockCursor();
            }
            else
            {
                invScript.invmenu.SetActive(false);
                Objetos.SetActive(false);
                //LockCursor();
            }
            
        }

    }
    private void DontLockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
