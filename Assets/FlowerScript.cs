using UnityEngine;
using System.Collections;

public class FlowerScript : MonoBehaviour {
    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.J))
        {
            levelManager.LoadNextLevel();
        }
	}
}
