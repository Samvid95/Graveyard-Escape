using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
    public LevelManager levelManager;
    public float speed = 2;
    public static int lives;

    public float force = 300;
    // Use this for initialization

    void Start () {
        lives = 9;
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.03f,1.0f) * force);
        if(lives <= 0)
        {
            levelManager.LoadLevel("CrowGameStartScene");
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart
        /*
        if(coll.gameObject.layer == 10)
        {
            lives--;
            Destroy(coll.gameObject);
            
        }
        */
        if (coll.gameObject.tag == "WinPoint")
        {
            Debug.Log("Wanted this collision!!");
            levelManager.LoadLevel("Act3CutScenesPart1");
        }
        else if(coll.gameObject.tag == "Boundry")
        {
            Debug.Log("");
        }
        else
        {
            lives--;
        }
        
    } 
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "BirdOpponent")
        {
            lives--;
            Destroy(coll.gameObject);
        }
    }
}

