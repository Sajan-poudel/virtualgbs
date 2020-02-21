using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayTenis : MonoBehaviour {

    public Text text;
    public string textDisplay;
    public string levelToLoad;
    public float textDisplayTime;
    private bool isDisplayed;
    private float startTime;
	
    // Use this for initialization
	void Start () {
        //
	}
	
	// Update is called once per frame
	void Update () {
        if (isDisplayed)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.LoadLevel(levelToLoad);
            }
            DisplayMannager();
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (!isDisplayed)
        {
            text.text = textDisplay;
            startTime = Time.time;
            isDisplayed = true;
        }
    }

    private void DisplayMannager()
    {
        if (Time.time- startTime >= textDisplayTime)
        {
            text.text = "";
            isDisplayed = false;
        }
    }
}
