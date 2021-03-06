﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;

}
public class PlayerController : MonoBehaviour {

    public float speed;
    public float tilt;
    public Boundary boundary;

    public GameObject shot;
    public GameObject shot2;
    public Transform shotSpawn;
    public Transform shotSpawn2;
    public float fireRate;
    private float nextFire;

    void Start ()
    {
		
	}

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            Instantiate(shot2, shotSpawn2.position, shotSpawn2.rotation);
            GetComponent<AudioSource>().Play();
        }
            
    }
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        this.GetComponent<Rigidbody>().velocity = movement * speed;


        this.GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(this.GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(this.GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
        );

        this.GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, this.GetComponent<Rigidbody>().velocity.x * -tilt);
    }
}
