using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    private SpriteRenderer spriteRenderer;
    void Start(){
    }
    void Update(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        Vector3 spritePosition = transform.position;

        if (Input.GetKey("w") && spritePosition[1] < -2)
        {
            Debug.Log("Jump");
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 14, 0);
        }
        if (Input.GetKey("a")){
            Debug.Log("Left");
            GetComponent<Rigidbody2D>().velocity = new Vector3(-2, 0, 0);
        }
        if (Input.GetKey("d")){
            Debug.Log("Right");
            GetComponent<Rigidbody2D>().velocity = new Vector3(2, 0, 0);
        }
        if (Input.GetKey("f")){
            Debug.Log("Dash");
            GetComponent<Rigidbody2D>().velocity = new Vector3(10, 0, 0);
        }

    }
}
