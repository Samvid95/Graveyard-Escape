using UnityEngine;
using System.Collections;

public class PlatformGen : MonoBehaviour {

    public GameObject platform;

    public float offset = 0.91f;
    public float prev = -12.13f;
	// Use this for initialization
	void Start () {
	    for(int i=0; i < 25; i++)
        {
            float position = prev + offset;
            GameObject playBoard = Instantiate(platform, new Vector3(position, -3.85f, 0), Quaternion.identity) as GameObject;
            playBoard.transform.parent = gameObject.transform;
            prev = position;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
