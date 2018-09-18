using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {


    public GameObject weapon;
    public GameObject lanz;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(weapon, lanz.transform.position, Quaternion.identity) as GameObject;
            clone.SetActive(true);
            //Debug.Log("hola");
        }

        

    }

    
}
