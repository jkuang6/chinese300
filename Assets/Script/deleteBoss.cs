using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteBoss : MonoBehaviour
{
    public GameObject boss;
    public AudioSource go;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Lotus"))
        {
            go.Play();
            Destroy(boss);
            
        }
    }
}
