using UnityEngine;
using System.Collections;

public class CatGameStartScript : MonoBehaviour {
    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            levelManager.LoadNextLevel();
        }
	}
}
