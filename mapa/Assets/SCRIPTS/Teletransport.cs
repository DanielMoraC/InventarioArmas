using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour {

    public GameObject player;

    public GameObject lanz;
    public GameObject cubo;

    static public bool posible = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject clone = Instantiate(cubo, lanz.transform.position, Quaternion.identity) as GameObject;
            clone.SetActive(true);
            //Debug.Log("Hola");     
            StartCoroutine("Enelsuelo");
        }
        if (Input.GetKeyDown(KeyCode.E) && posible)
        {
            player.transform.position = cubo.transform.position;
            Destroy(cubo, 0);
        }
    }

    public IEnumerator Enelsuelo()
    {
        posible = true;
        yield return new WaitForSeconds(10);
        posible = false;
        Destroy(cubo, 0);
    }
    
}
