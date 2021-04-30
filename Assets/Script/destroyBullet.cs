using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullet : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        StartCoroutine(coroutineB());
    }

    IEnumerator coroutineB()
    {

        yield return new WaitForSeconds(2.5f);
        Destroy(bullet);
    }

}
