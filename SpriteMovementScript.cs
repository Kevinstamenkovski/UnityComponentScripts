using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    int i = 0;
    private Rigidbody2D rigidbody;

    private void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        float HorizontalMovement = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(7f * HorizontalMovement, rigidbody.velocity.y);

        if (Input.GetButton("Jump")){
           rigidbody.velocity = new Vector2(rigidbody.velocity.x , 14f);
        }

        if (Input.GetKeyDown("f")){
            rigidbody.velocity = new Vector2(14f * HorizontalMovement, rigidbody.velocity.y);
        }

    }
}
