using UnityEngine;
public class RotationScript : MonoBehaviour{
    public float rotationSpeed = 50f;
    private bool isRotating = true;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            isRotating = !isRotating;
        }
        if (isRotating){
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}

