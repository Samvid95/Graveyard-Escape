using UnityEngine;
using System.Collections;

public class CatFlyMixed : MonoBehaviour {
    public float speed = 2;
    public LevelManager levelManager;
    public float force = 300;
    public string winLevel;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z)) {
            GetComponent<Animator>().SetBool("Fly123", true);
            GetComponent<Animator>().Play("Fly");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.03f, 1.0f) * force);
            GetComponent<Animator>().SetBool("Fly123", false);
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
            levelManager.LoadLevel(winLevel);
        }
        else if (coll.gameObject.tag == "Boundry")
        {
            
        }
       
      

    }
}
