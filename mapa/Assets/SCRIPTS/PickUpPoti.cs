using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPoti : MonoBehaviour {

    Inventory invScript;

    public Button RemoveB;

    public bool item;
    public GameObject itemIcon;
    public int stack = 0;

    public Text cont;

    bool pickedUp = false;


    // Use this for initialization
    void Start()
    {
        invScript = GameObject.FindWithTag("GameController").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider player)
    {
        if (player.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E) && !pickedUp && stack == 0)
            {
                if (item)
                {
                    GameObject i = Instantiate(itemIcon);
                    i.transform.SetParent(invScript.potiv.transform);
                    //Destroy(gameObject);
                    stack += 2;
                }

            }
            else if (Input.GetKeyDown(KeyCode.E) && !pickedUp && stack > 1)
            {
                if (item)
                {
                    cont.text = stack.ToString();
                    cont.transform.SetParent(invScript.potivt.transform);
                    stack++;
                }

            }
        }

    }
    
}
