using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour{

    private Animator animator;

    private void Start(){
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Trap")){
            Death();
        }    
    }

    private void Death(){
        animator.SetTrigger("death");
    }
}
