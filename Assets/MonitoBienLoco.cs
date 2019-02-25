using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitoBienLoco : MonoBehaviour {
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public float velocida;
    public float salto;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
   
    }
	
	// Update is called once per frame
	void FixedUpdate () {
	if(Input.GetKey(KeyCode.A))
        {
            sprite.flipX = true;
            rb.AddForce(-transform.right * velocida);
        }
   
    	if(Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
           
            rb.AddForce(transform.right* velocida);
        }
	
	if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up* salto, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * velocida);
        }
    }
    	
	}
     

