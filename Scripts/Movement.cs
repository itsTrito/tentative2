using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator an;
    [SerializeField]
    private Character character;
    private float ms;
    public float dashForce = 8f;
    public float dashCost = 5f;
    private Vector2 _movement;

    void Awake()
    {
        ms = character.moveSpeed;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        an = GetComponent<Animator>();
    }

    void Update()
    {
        Dash();
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

	void Dash()
	{
		if(Input.GetButtonDown("Jump")){
            if (character.stamina > 0){
                rb.position += _movement *  dashForce;
                character.stamina -= dashCost;
                Debug.Log(character.stamina);
            }
            else{
                Debug.Log("No Stamina");
            }
		}		
	}
}