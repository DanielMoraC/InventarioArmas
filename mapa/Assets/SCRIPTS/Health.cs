using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public Image HPBar;
    public Text ratioText;

    public float hitpoint = 150;
    public float maxhitpoint = 150;

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
        ratioText.text = (ratio * 100).ToString("0") + "%";
    }

    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint<0)
        {
            hitpoint = 0;
            Debug.Log("Death");
        }
        UpdateHealthbar();
    }

    private void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxhitpoint)
        {
            hitpoint = maxhitpoint;
        }
        UpdateHealthbar();
    }
}
