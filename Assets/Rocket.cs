﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Rocket : MonoBehaviour
{
    //Components of GameObjects
    Rigidbody rigidBody; //to access rigid body components

    AudioSource thurstSFX;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        thurstSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Thrusting");
            rigidBody.AddRelativeForce(Vector3.up);
            thurstSFX.Play();
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Turn Left");
            transform.Rotate(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("Turn Right");
            transform.Rotate(- Vector3.forward);
        }
    }
}
