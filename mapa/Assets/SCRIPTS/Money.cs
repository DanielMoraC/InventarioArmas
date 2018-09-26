using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    public Text cont;

    public int dinero;

    void Update()
    {
        cont.text = dinero.ToString();
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Moneda20")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dinero += 20; 
            }
        }

        if (col.tag == "Moneda10")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dinero += 10;
            }
        }
    }
}
