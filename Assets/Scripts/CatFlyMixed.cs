using UnityEngine;
using System.Collections;

public class CatFlyMixed : MonoBehaviour {
    public float speed = 2;
    public LevelManager levelManager;
    public float force = 300;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.03f, 1.0f) * force);
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
            levelManager.LoadLevel("Act3CutScenes");
        }
        else if (coll.gameObject.tag == "Boundry")
        {
            Debug.Log("");
        }
        else if (coll.gameObject.layer == 10)
        {
            catMoveMixed.health--;
            Destroy(coll.gameObject);
        }
      

    }
}
