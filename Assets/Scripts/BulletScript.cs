using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    public GameObject particle1;
    public GameObject particle2;

    Vector3 force;
    Rigidbody rb;

    void Start () {
       rb = GetComponent<Rigidbody>();
       // force = new Vector3(0,0,5);
        
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward*20);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Box")
        {
            GunScript.numBox -= 1;
            Instantiate(particle2, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        else
        {
            Instantiate(particle1, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
