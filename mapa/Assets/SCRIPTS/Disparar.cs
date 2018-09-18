using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {

    //con esto definimos la velocidad de la bala y hacia donde va

    public GameObject character;
    Vector3 direccion;


    // Use this for initialization
    void Start()
    {

        //lo ponemos en start para que vaya hacia donde mira el personaje

        float vX = 20f * Time.deltaTime;
        transform.Translate(character.transform.forward * vX);
        direccion = character.transform.forward;


    }

    // Update is called once per frame
    void Update()
    {

        //y despues en el update para que siga hacia donde iba y no siga siempre al personaje

        float vX = 20f * Time.deltaTime;

        transform.Translate(direccion * vX);

    }
}
