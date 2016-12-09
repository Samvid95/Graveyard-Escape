using UnityEngine;
using System.Collections;

public class GhostGen : MonoBehaviour {
    public GameObject ghost;
    public Vector2 Point1;
    public Vector2 Point2;
    public Vector2 Point3;
    public Vector2 Point4;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Generate", 1, 2);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void Generate()
    {
        int rand = Random.Range(1, 5);
        switch (rand)
        {
            case 1:
                GameObject tempGhost1 = Instantiate(ghost, new Vector3(Point1.x, Point1.y, 0), Quaternion.identity) as GameObject;
                break;
            case 2:
                GameObject tempGhost2 = Instantiate(ghost, new Vector3(Point2.x, Point2.y, 0), Quaternion.identity) as GameObject;
                break;
            case 3:
                GameObject tempGhost3 = Instantiate(ghost, new Vector3(Point3.x, Point3.y, 0), Quaternion.identity) as GameObject;
                break;
            case 4:
                GameObject tempGhost4 = Instantiate(ghost, new Vector3(Point4.x, Point4.y, 0), Quaternion.identity) as GameObject;
                break;
            default:
                break;

        }

    }
}
