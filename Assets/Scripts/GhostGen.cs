using UnityEngine;
using System.Collections;

public class GhostGen : MonoBehaviour {
    public GameObject ghost;
    public Vector2[] Points;

	// Use this for initialization
	void Start () {

        InvokeRepeating("Generate", 1, 2);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void Generate()
    {
        int rand = Random.Range(0, Points.Length);
        GameObject tempGhost = Instantiate(ghost, new Vector3(Points[rand].x,Points[rand].y,0), Quaternion.identity) as GameObject;
  
    }
}
