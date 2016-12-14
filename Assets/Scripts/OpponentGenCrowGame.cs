using UnityEngine;
using System.Collections;

public class OpponentGenCrowGame : MonoBehaviour {
    public Transform[] genPoints;
    public Transform target;
    public GameObject opponentBird;
    private float moveVelocity = -1.5f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Generate", 1, 2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void Generate()
    {
        int random = Random.Range(0, genPoints.Length);
        float speedMultiplier = Random.Range(1.0f, 3.0f);
        GameObject opponent = Instantiate(opponentBird, new Vector3(genPoints[random].position.x, target.position.y, 0.0f), Quaternion.identity) as GameObject;
        opponent.GetComponent<Rigidbody2D>().velocity = new Vector3(moveVelocity * speedMultiplier, 0.0f, 0.0f);
    }
}
