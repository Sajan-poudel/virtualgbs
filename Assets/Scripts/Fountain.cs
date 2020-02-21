using UnityEngine;
using System.Collections;

public class Fountain : MonoBehaviour {
    public GameObject Ejector;
    public GameObject Water;
	// Use this for initialization
	void Start () {
        InvokeRepeating("doAnimation", .25f, 10);
    }
	
	// Update is called once per frame
	void Update () {
      //  Invoke("doAnimation", 1);
        // doAnimation();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            print("I found you");
            doAnimation();
        }
    }

    void doAnimation()
    {
        Instantiate(Water, Ejector.transform.position, Quaternion.identity);
    }
}
