using UnityEngine;
using System.Collections;

public class catMoveMixed : MonoBehaviour {
    public float movementSpeed;
    public float jumpSpeed;

    private bool hit = false;
    public static int health = 9;
    public string looseLevel;
    public string winLevel;
    public LevelManager levelManager;

    private float moveVelocity;
    private bool grounded;
    private Vector2 direction;


    Vector3 screenSize;
    // Use this for initialization
    void Start()
    {
        health =9;
        direction = new Vector2(1.0f, 0.0f);
        GetComponent<CatFlyMixed>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        moveVelocity = 0;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("Move", true);
            GetComponent<Animator>().Play("Standing");
            GetComponent<Animator>().SetBool("Move", false);
            moveVelocity += movementSpeed;
            direction.x = 1.0f;

        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            // GetComponent<Animator>().SetBool("moveRight", false);
            GetComponent<Animator>().SetBool("Move", true);
            GetComponent<Animator>().Play("Standing");
            GetComponent<Animator>().SetBool("Move", false);
            moveVelocity -= movementSpeed;
            direction.x = -1.0f;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hit = true;
            GetComponent<Animator>().SetBool("Fight", true);
            //Debug.Log(GetComponent<Animator>().GetBool("Fight"));
            GetComponent<Animator>().Play("Claw");
            // Debug.Log(GetComponent<Animator>().GetBool("Fight"));
            GetComponent<Animator>().SetBool("Fight", false);

        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        if (Input.GetKey(KeyCode.X) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(GetComponent<Rigidbody2D>().velocity.x, jumpSpeed, 0);
        }
        hit = false;

        if (health <= 0)
        {
            levelManager.LoadLevel(looseLevel);
        }
    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Claw") && col.gameObject.tag == "Ghost")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Ghost")
        {
            health -= 1;
            Debug.Log("The health Value is:" + health);
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Monster1")
        {
            health -= 1;
        }

        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }

        if (col.gameObject.tag == "Fence")
        {
            levelManager.LoadLevel(winLevel);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Claw") && col.gameObject.tag == "BirdOpponent")
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "BirdOpponent"){
            
            health -= 1;
            Destroy(col.gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        GetComponent<CatFlyMixed>().enabled = true;
        Destroy(coll.gameObject);
    }
}
