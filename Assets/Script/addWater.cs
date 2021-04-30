using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addWater : MonoBehaviour
{

    public Healthbar healthBar;
    public GameObject waterOrb;
    public AudioSource drink;

    void OnTriggerEnter(Collider collision)
    {
        drink.Play();
        if (collision.gameObject.tag == "Player")
        {
            healthBar.addWater();
            Destroy(waterOrb);
   
        }
    }
}
