using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GunScript : MonoBehaviour {
    public static int numBox;
    public static bool missionOn;
    public GameObject[] gunPoints;
    public GameObject gun;
    public GameObject bullet;
    public GameObject box;
    public GameObject player;
    public Text text;
    public Text boxText;
    public Text time;
    public int totalTime;

    private float timeRef;
    private bool placed;
	// Use this for initialization
	void Start () {
        numBox = 4;
       // numBox = gunPoints.Length;
    }
	
	// Update is called once per frame
	void Update () {
        ShootHandeler();
	}

    void placeBox()
    {
        gunPoints = GetSuffled(gunPoints);
        for (int i = 0; i <= 3; i++)
        {
            Instantiate(box, gunPoints[i].transform.position, Quaternion.identity);
        }
    }
    void ShootHandeler()
    {
        if (missionOn)
        {
            boxText.text = "Boxes to find : " + numBox;
            gun.gameObject.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, player.transform.position, player.transform.rotation);
            }
            if (!placed)
            {
                placeBox();
                placed = true;
                timeRef = Time.time;
            }
            numBoxChecker();
            TimeMannager();
        }
        else
        {
            gun.gameObject.SetActive(false);
        }
    }

    public GameObject[] GetSuffled(GameObject[] intArray)
    {
        for(int i=0; i<=intArray.Length-1; i++)
        {
            int index = Random.Range(0, intArray.Length - 1);
            GameObject temp = intArray[index];
            intArray[index] = intArray[i];
            intArray[i] = temp;
        }
        return intArray;
    }

    void numBoxChecker()
    {
        if(numBox <=0)
        {
            text.text = "You Won";
            Invoke("reloadAfter", 3);
        }
    }

    void TimeMannager()
    {
        time.text =  "Time: "+Mathf.RoundToInt(Time.time - timeRef).ToString()+ " / "+totalTime;
        if(Time.time - timeRef >= totalTime)
        {
            text.text = "You looosed";
            Invoke("reloadAfter", 2);
        }
    }
    
    void reloadAfter()
    {
        boxText.text = "";
        text.text = "";
        time.text = "";
        missionOn = false;
        Application.LoadLevel(Application.loadedLevel);
    }
}
