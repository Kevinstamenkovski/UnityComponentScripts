using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FallDeathScript : MonoBehaviour{
  private BoxCollider2D collider2D;
  private Rigidbody2D rigidbody;
  [SerializeField] private int fallLimit = -20;
  private Vector2 spawnPosition = new Vector2(-16.25f, -6.5f);
  private void Start(){
        rigidbody = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<BoxCollider2D>();
    
    }
  
  private void Update(){
    if (rigidbody.position.y < fallLimit) {
      rigidbody.position = spawnPosition;
      Debug.Log(rigidbody.velocity.y);
    }
  }
}

