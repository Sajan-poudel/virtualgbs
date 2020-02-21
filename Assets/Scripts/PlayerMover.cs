using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {
    Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float xSpeed = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float zSpeed = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        rb.AddForce(xSpeed, 0, zSpeed);
        print("Doing");
    }
}
