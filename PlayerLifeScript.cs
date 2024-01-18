using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour{
    private Rigidbody2D rigidbody;
    private Animator animator;
    private void Start(){
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Trap")){
            Death();
        }    
    }
    private void Death(){
        rigidbody.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
    }
    private void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
