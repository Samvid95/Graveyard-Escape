using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text timeText;
    public static float myTimer = 30;
    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
        myTimer = 45;
	}
	
	// Update is called once per frame
	void Update () {
        myTimer -= Time.deltaTime;
        timeText.text = "Time left: " + myTimer.ToString("f0"); 
        if(myTimer <= 0)
        {
            levelManager.LoadLevel("CatGameStartScene");
        }
	}
}
