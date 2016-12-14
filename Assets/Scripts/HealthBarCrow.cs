using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBarCrow : MonoBehaviour {

    public Text healthText;
    public LevelManager levelManager;
    public string levelName;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Lives: " + Bird.lives.ToString("f0");
        if (Bird.lives <= 0)
        {
            levelManager.LoadLevel(levelName);
        }
    }
}
