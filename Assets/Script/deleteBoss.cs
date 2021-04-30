using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteBoss : MonoBehaviour
{
    public GameObject boss;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Lotus"))
        {
            Destroy(boss);
        }
    }
}
