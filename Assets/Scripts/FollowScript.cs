using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

    public Transform[] wayPointList;
    public int size;
    public int currentWayPoint = 0;
    Transform targetWayPoint;

    public float speed = 4f;

    // Use this for initialization
    void Start()
    {
        size = wayPointList.Length;
    }

    // Update is called once per frame
    void Update()
    {
        // check if we have somewere to walk
            if (targetWayPoint == null)
                targetWayPoint = wayPointList[currentWayPoint];
            walk();
    
    }

    void walk()
    {
        // rotate towards the target
        

        // move towards the target
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if (transform.position == targetWayPoint.position)
        {
            currentWayPoint = (currentWayPoint + 1) % wayPointList.Length;
            targetWayPoint = wayPointList[currentWayPoint];
        }
    }
}
