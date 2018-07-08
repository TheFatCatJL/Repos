﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvasiveManeuver : MonoBehaviour
{
    public Vector2 startWait;
    public Vector2 maneuverWait;
    public Vector2 maneuverTime;
    public Transform playertransform;

    private float targetManeuver;
    public float smoothing;
    public float dodge;
    public float tilt;

    private Rigidbody rb;
    private float currentSpeed;
    public Boundary boundary;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = rb.velocity.z;
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(Evade());
	}
	
    IEnumerator Evade()
    {
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));
        while (true)
        {
            if (playertransform != null)
            {
                targetManeuver = playertransform.position.x;
            }
            else
            {
                targetManeuver = Random.Range(1, dodge * -Mathf.Sign(transform.position.x));
            }
            yield return new WaitForSeconds(Random.Range(maneuverTime.x,maneuverTime.y));
            targetManeuver = 0;
            yield return new WaitForSeconds(Random.Range(maneuverWait.x,maneuverWait.y));
        }
    }

	void FixedUpdate ()
    {
        float newManeuver = Mathf.MoveTowards(rb.velocity.x,targetManeuver,Time.deltaTime * smoothing);
        rb.velocity = new Vector3(newManeuver,0.0f,currentSpeed);
        rb.position = new Vector3
        (
             Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
             0.0f,
             Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
	}
}
