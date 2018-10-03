using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {

    Vector3 direccion;
    public GameObject Lanzador;


    // Use this for initialization
    void Start()
    {
        float vX = 20f * Time.deltaTime;
        transform.Translate(Lanzador.transform.forward * vX);
        direccion = Lanzador.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        float vX = 20f * Time.deltaTime;
        transform.Translate(direccion * vX);
    }
}
