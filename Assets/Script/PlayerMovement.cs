using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rd;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rd.velocity = new Vector2(dirX * 7f, rd.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rd.velocity = new Vector2(rd.velocity.x, 14f);
            Debug.Log("Jump");
        }

        if(dirX > 0f)
        {
            anim.SetBool("running", true);
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
}
