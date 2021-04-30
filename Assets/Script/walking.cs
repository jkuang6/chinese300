using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    CharacterController cc;
    public AudioSource walkingSound;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (cc.velocity.magnitude > 2f && walkingSound.isPlaying == false)
        {
            Debug.Log("walking");
            walkingSound.Play();
        }
        else if(cc.velocity.magnitude < 2f && walkingSound.isPlaying == true)
        {
            walkingSound.Stop();
        }
        
    }
}
