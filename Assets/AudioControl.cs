using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

    private AudioSource myAudioSource;

	// Use this for initialization
	void Start () {
        myAudioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.P))
        {
            // toggle play
            if (myAudioSource.isPlaying)
                myAudioSource.Stop();
            else
                myAudioSource.Play();
        }

	}
}
