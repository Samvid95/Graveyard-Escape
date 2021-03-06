﻿using UnityEngine;
using System.Collections;

public class CatBirdMixMovement : MonoBehaviour {

    public float movementSpeed;

    private float moveVelocity;
    private bool hit = false;
    public static int health = 7;
    public string levelName;
    public string winLevel;
    public LevelManager levelManager;
    private bool grounded = true;


    //Bird Game Variables
    public float speed = 2;
    public float force = 300;
    // Use this for initialization
    void Start()
    {
        health = 7;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            grounded = false;
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
        if (grounded == true)
        {
            moveVelocity = 0;

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                //Debug.Log("Right Arrow is pressed!!");
                GetComponent<Animator>().SetBool("Move", true);
                GetComponent<Animator>().Play("Standing");
                GetComponent<Animator>().SetBool("Move", false);
                moveVelocity += movementSpeed;
            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                //Debug.Log("Left Arrow is pressed!!");
                GetComponent<Animator>().SetBool("Move", true);
                GetComponent<Animator>().Play("Standing");
                GetComponent<Animator>().SetBool("Move", false);
                moveVelocity -= movementSpeed;
            }

            //Debug.Log("The movement velocity should be:" + new Vector2(moveVelocity,GetComponent<Rigidbody2D>().velocity.y)); 
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, transform.position.y);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                hit = true;
                GetComponent<Animator>().SetBool("Fight", true);
                //Debug.Log(GetComponent<Animator>().GetBool("Fight"));
                GetComponent<Animator>().Play("Claw");
                // Debug.Log(GetComponent<Animator>().GetBool("Fight"));
                GetComponent<Animator>().SetBool("Fight", false);

            }
            hit = false;

            if (health <= 0)
            {
                levelManager.LoadLevel(levelName);
            }
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
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Fence")
        {
            levelManager.LoadLevel(winLevel);
        }
        if(col.gameObject.tag == "Ground")
        {
            Debug.Log("The collision we needed!!");
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log("Exiting collisoin!!");
        if (col.gameObject.tag == "Ground")
        {
            Debug.Log("Exiting ground collision");
            grounded = false;
        }
        
    }

}
