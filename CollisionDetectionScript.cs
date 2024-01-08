using UnityEngine;

public class TerrainCollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain")){
            // Action if Sprite hit an Object
        }
    }
}
