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
