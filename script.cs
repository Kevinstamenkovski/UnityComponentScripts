using UnityEngine;

public class RotationScript : MonoBehaviour{
    public float rotationSpeed = 50f;
    
    void Update(){
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
