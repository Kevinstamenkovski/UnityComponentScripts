using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    int i = 0;
    private Rigidbody2D rigidbody;
    private Animator animation;
    private float HorizontalMovement = 0f;
    private SpriteRenderer sprite;

    private void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update(){
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(7f * HorizontalMovement, rigidbody.velocity.y);

        if (Input.GetButtonDown("Jump")){
           rigidbody.velocity = new Vector2(rigidbody.velocity.x , 14f);
        }

        if (rigidbody.position.y < -20) {
            rigidbody.position = new Vector2(-16.25f, -6.5f);
            Debug.Log(rigidbody.velocity.y);
        }

        updateAnimations();
    }

    void updateAnimations(){
        if (HorizontalMovement > 0f){
            animation.SetBool("isRunning", true);
            sprite.flipX = false;
        }else if (HorizontalMovement < 0f){
            animation.SetBool("isRunning", true);
            sprite.flipX = true;
        }else{
            animation.SetBool("isRunning", false);
        }
    }
}
