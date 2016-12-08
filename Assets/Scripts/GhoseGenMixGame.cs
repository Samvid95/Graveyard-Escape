using UnityEngine;
using System.Collections;

public class GhoseGenMixGame : MonoBehaviour {

    public GameObject ghost;
    public Vector2 Point1;
    public Vector2 Point2;
    public Vector2 Point3;

    public Transform target;
    private float xValue;
    // Use this for initialization
    void Start()
    {

        InvokeRepeating("Generate", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Generate()
    {
        int rand = Random.Range(1, 4);
        switch (rand)
        {
            case 1:
                GameObject tempGhost1 = Instantiate(ghost, new Vector3(Point1.x, target.position.y, 0), Quaternion.identity) as GameObject;
                break;
            case 2:
                GameObject tempGhost2 = Instantiate(ghost, new Vector3(Point2.x, target.position.y, 0), Quaternion.identity) as GameObject;
                break;
            case 3:
                GameObject tempGhost3 = Instantiate(ghost, new Vector3(Point3.x, target.position.y, 0), Quaternion.identity) as GameObject;
                break;
            default:
                break;

        }

    }
}
