using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    private Rigidbody2D rigidbody;
    private Animator animation;
    private float HorizontalMovement = 0f;
    private SpriteRenderer sprite;
    private Vector2 spawnPosition = new Vector2(-16.25f, -6.5f);
    [SerializeField] private float JumpForce = 14f;
    [SerializeField] private float MoveSpeed = 7f;

    private enum MovementState { idle, running, falling, jumping }

    private MovementState state = MovementState.idle;


    private void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update(){
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(MoveSpeed * HorizontalMovement, rigidbody.velocity.y);

        if (Input.GetButtonDown("Jump")){
           rigidbody.velocity = new Vector2(rigidbody.velocity.x , JumpForce);
        }

        if (rigidbody.position.y < -20) {
            rigidbody.position = spawnPosition;
            Debug.Log(rigidbody.velocity.y);
        }

        updateAnimations();
    }

    void updateAnimations(){

        MovementState state;

        if (HorizontalMovement > 0f){
            state = MovementState.running;
            sprite.flipX = false;
        }else if (HorizontalMovement < 0f){
            state = MovementState.running;
            sprite.flipX = true;
        }else{
            state = MovementState.idle;
        }

        if(rigidbody.velocity.y > .1f){
            state = MovementState.jumping;
        }else if(rigidbody.velocity.y < -.1f){
            state = MovementState.falling;
        }

        animation.SetInteger("state", (int)state);
    }
}
