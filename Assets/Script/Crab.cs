using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    [SerializeField] private float startWaitTime = 3f;
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed;

    private Animator anim;
    private SpriteRenderer sprite;
    
    private Vector2 lastFramePos;
    private Vector2 currentFramePos;

    private float waitTime;
    private int i = 0;

    void Start()
    { 
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        waitTime = startWaitTime;
        anim.SetBool("isMoving", true);
    }

    void Update()
    {
        currentFramePos = transform.position;
        if(Vector2.Distance(currentFramePos, waypoints[i].transform.position) < 0.1f)
        {

            if(waitTime <= 0)
            {
                i++;

                if(i >= waypoints.Length)
                {
                    i = 0;
                }

                waitTime = startWaitTime;
                anim.SetBool("isMoving", true);
            }

            else
            {
                waitTime -= Time.deltaTime;
                anim.SetBool("isMoving", false);
            }
        }
        UpdateSprite();

        transform.position = Vector2.MoveTowards(currentFramePos, waypoints[i].transform.position, speed * Time.deltaTime);
        lastFramePos = currentFramePos;


    }

    private void UpdateSprite()
    {

        if(currentFramePos.x < lastFramePos.x)
        {
            sprite.flipX = false;
        }
        else if(currentFramePos.x > lastFramePos.x)
        {
            sprite.flipX = true;
        }

    }

}
