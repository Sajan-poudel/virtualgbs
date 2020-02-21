using UnityEngine;
using System.Collections;

public class DestroyAfterScript : MonoBehaviour {
    public float lifeSpan;
    float stTime;
	// Use this for initialization
	void Start () {
        stTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time - stTime > lifeSpan)
        {
            Destroy(gameObject);
        }
	}
}
