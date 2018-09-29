using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edisparar : MonoBehaviour {

    public int disparando = 1;
    Transform player;
    public GameObject weapon;
    public Transform gunEnd;
    public int seconds;


    // Use this for initialization
    void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && disparando ==1)
        {
            StartCoroutine("Shooting");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StopCoroutine("Shooting");
            disparando = 1;
        }
    }
    public IEnumerator Shooting()
    {

            disparando = 0;            
            GameObject clone = Instantiate(weapon, gunEnd.position, gunEnd.rotation);
            clone.SetActive(true);
            yield return new WaitForSeconds(seconds);
            disparando = 1;


    }
}
