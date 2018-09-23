using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Image HPBar;
    public Text ratioText;

    public float hitpoint = 100;
    public float maxhitpoint = 100;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UpdateHealthbar();
        
    }

    private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxhitpoint;
        HPBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("0");
    }

    private void TakeDamage()
    {
        hitpoint -= HealorDamage.damage;
        if (hitpoint<0)
        {
            hitpoint = 0;
            Debug.Log("Death");
        }
        UpdateHealthbar();
    }

    private void HealDamage()
    {
        hitpoint += HealorDamage.heal;
        if (hitpoint > maxhitpoint)
        {
            hitpoint = maxhitpoint;
        }
        UpdateHealthbar();

    }
    private void TakeDamageP(float damageP)
    {
        hitpoint -= damageP;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("Death");
        }
        UpdateHealthbar();
    }
}
