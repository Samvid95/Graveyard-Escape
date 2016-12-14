﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBarMixed : MonoBehaviour {

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
        healthText.text = "Lives: " + catMoveMixed.health.ToString("f0");
        if (catMoveMixed.health <= 0)
        {
            levelManager.LoadLevel(levelName);
        }
    }
}
