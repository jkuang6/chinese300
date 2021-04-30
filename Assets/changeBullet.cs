using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBullet : MonoBehaviour
{
    public GameObject Player;
    public GameObject bullet1;


    void OnTriggerEnter(Collider other)
    {
        //Player.bullet = bullet1;
        Player.GetComponent<playerMovement2>().bullet = bullet1;

    }
}
