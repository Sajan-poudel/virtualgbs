using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour {
    public float lifeSpan;

    float startTime;
    Vector3 power;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        startTime = Time.time;
        //power = new Vector3(Random.Range(-.015f, .015f), Random.Range(0.025f ,0.05f), Random.Range(-.015f, .015f));
       // rb.AddForce(power);
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - startTime > lifeSpan)
        {
            Destroy(gameObject);
        }
	}
}
