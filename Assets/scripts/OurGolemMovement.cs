using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OurGolemMovement : MonoBehaviour {

    // Use this for initialization
    private Rigidbody body;
    private float force=10f;
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        body.velocity = new Vector3(-h*force,0f,0f);
	}
}
