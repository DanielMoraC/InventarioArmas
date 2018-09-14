using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {


    //Para la cámara
    public float horizontalSpeed;
    public float verticalSpeed;
    float h;
    float v;

    //Para el movimiento 
    public float velocidad = 0.1f;

    Vector3 Limite;
    //private Rigidbody rbody;

    public Rigidbody cuerpo;

    //public GameObject cuerpo;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        //if (MenuPausa.GameIsPaused == false)
        //{
 
            h = horizontalSpeed * Input.GetAxis("Mouse X");
            v = verticalSpeed * Input.GetAxis("Mouse Y");

            transform.Rotate(0, h, 0);

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, velocidad);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, -velocidad);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-velocidad, 0, 0);
            }

        if (Input.GetKey(KeyCode.D))
        {
           transform.Translate(velocidad, 0, 0);
        }

        



        //}

    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cuerpo.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            //transform.Translate(0, 2, 0);
        }
    }
}
