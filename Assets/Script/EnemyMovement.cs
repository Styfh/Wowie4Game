using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Vector2 lastFramePos;
    private Vector2 currentFramePos;

    private FollowWaypoint movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<FollowWaypoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
