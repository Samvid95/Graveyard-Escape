using UnityEngine;
using System.Collections;

public class FenceGen : MonoBehaviour {

    public GameObject fence;

    public float offset = 0.91f;
    public float prev = 9.04f;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            float position = prev + offset;
            GameObject playBoard = Instantiate(fence, new Vector3(position, -4.15f, 0), Quaternion.identity) as GameObject;
            playBoard.transform.parent = gameObject.transform;
            prev = position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
