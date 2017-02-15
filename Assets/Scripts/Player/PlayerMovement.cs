using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 1;

    private Rigidbody2D rigid;
    
	void Start () {
        rigid = transform.GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
	}
	
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 moveInput = new Vector2(horizontal, vertical);
        rigid.velocity = moveInput * speed;
	}
}
