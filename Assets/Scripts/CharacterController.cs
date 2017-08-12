using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    Rigidbody2D playerRigidbody;
    public float speed;
    float walk;

    // Use this for initialization
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        walk = 0;
    }

    // Update is called once per frame
    void Update()
    {
        walk = Input.GetAxis("Horizontal");
        playerRigidbody.velocity = new Vector2(walk * speed, playerRigidbody.velocity.y);

        if (walk > 0 && spriteRenderer.flipX)
        {
            flip();
        }
        else if (walk < 0 && !spriteRenderer.flipX)
        {
            flip();
        }

    }

    void flip()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }
}
