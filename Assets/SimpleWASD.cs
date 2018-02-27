using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWASD : MonoBehaviour {


    public float speed = 5.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) moveDirection += Vector3.forward;
        if (Input.GetKey(KeyCode.A)) moveDirection -= Vector3.right;
        if (Input.GetKey(KeyCode.S)) moveDirection -= Vector3.forward;
        if (Input.GetKey(KeyCode.D)) moveDirection += Vector3.right;

        transform.position += moveDirection.normalized * speed * Time.deltaTime;

    }
}
