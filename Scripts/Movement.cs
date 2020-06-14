using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator an;
    [SerializeField]
    private Character player;
    private float ms;

    private Vector2 _movement;
    void Awake()
    {
        ms = player.moveSpeed;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        an = GetComponent<Animator>();
    }

    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        an.SetFloat("Horizontal", _movement.x);
        an.SetFloat("Vertical", _movement.y);
        an.SetFloat("Speed", _movement.magnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + _movement * ms * Time.deltaTime);
        if (_movement.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
