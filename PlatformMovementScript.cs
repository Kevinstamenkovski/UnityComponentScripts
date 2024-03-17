using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 5f;
    private Vector3 initialPosition;
    private float direction = 1;  
    void Start(){
        initialPosition = transform.position;
    }
    void Update(){
        float newPosition = Mathf.PingPong(Time.time * speed, distance);
        Vector3 targetPosition = initialPosition + Vector3.right * newPosition * direction;

        transform.position = targetPosition;
    }
}
