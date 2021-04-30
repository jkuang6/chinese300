using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Healthbar healthBar;

    public float speed = 12f;
    public float gravity = -9.81f;
    public GameObject cannon;
    public GameObject bullet;
    public float force = 700f;

    Vector3 veloctiy;

    // Update is called once per frame
    void Update()
    {


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        veloctiy.y += gravity * Time.deltaTime;

        controller.Move(veloctiy * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 2;
            newBullet.GetComponent<Rigidbody>().AddForce(-(newBullet.transform.forward * 1500));
        }



    }

}
