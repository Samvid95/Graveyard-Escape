using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    public float speed = 0;

    public float switchTime = 2;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        
        if(gameObject.tag == "WinPoint")
        {
            speed = 0;
        }
        else
        {
            InvokeRepeating("Switch", 0, switchTime);
        }
    }


    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
