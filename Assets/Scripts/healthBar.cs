using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class healthBar : MonoBehaviour {

    public Text healthText;
    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        healthText.text = "Lives: " +PlayerMovement.health.ToString("f0");
        if(PlayerMovement.health <= 0)
        {
            levelManager.LoadLevel("CatGameStartScene");
        }
	}
}
