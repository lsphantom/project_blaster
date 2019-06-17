﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
	Rigidbody rocketRigidBody;
	AudioSource rocketAudioSource;

    // Start is called before the first frame update
    void Start()
    {
		rocketRigidBody = GetComponent<Rigidbody>();
		rocketAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		ProcessInput();
        
    }

	private void ProcessInput()
	{
		if (Input.GetKey(KeyCode.Space)){
			//print("Space:Thrust");
			rocketRigidBody.AddRelativeForce(Vector3.up);
			if (!rocketAudioSource.isPlaying) {
				rocketAudioSource.Play();
			}
		}
		else {
			rocketAudioSource.Stop();
		}

		if (Input.GetKey(KeyCode.A)) {
			//print("A:Left");
			transform.Rotate(Vector3.forward);
		}

		if (Input.GetKey(KeyCode.D))
        {
			//print("D:Right");
			transform.Rotate(-Vector3.forward);
        }
	}
}
