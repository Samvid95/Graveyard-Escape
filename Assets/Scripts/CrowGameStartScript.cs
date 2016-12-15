using UnityEngine;
using System.Collections;

public class CrowGameStartScript : MonoBehaviour {

    public LevelManager levelManager;
    public string levelName;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if(levelName == null)
            {
                levelManager.LoadNextLevel();
            }
            else
            {
                levelManager.LoadLevel(levelName);
            }
        }
    }
}
