using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MissionStartScript : MonoBehaviour {
    public Text text;
    float stTime;
    bool came;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    if(came == true && GunScript.missionOn == false)
        {
            if (Input.GetKey(KeyCode.M))
            {
                GunScript.missionOn = true;
                text.text = "Mission Started find and destroy all Bosx";
                came = false;
            }
            if(Time.time - stTime > 5)
            {
                text.text = "";
                came = false;
            }
        }
        else if (GunScript.missionOn == true && Input.GetKey(KeyCode.Escape))
        {
            GunScript.missionOn = false;
            Application.LoadLevel(Application.loadedLevel);
        }
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && GunScript.missionOn == false)
        {
            print("Found Player");
            came = true;
            text.text = "Press M to play Mission";
            stTime = Time.time;
        }
    }
 }
