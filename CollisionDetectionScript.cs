using UnityEngine;

public class TerrainCollisionDetection : MonoBehaviour{
    
    [SerializeField] private string terrainTag = "Terrain";
    
    private void OnCollisionEnter(Collision collision){
        CheckTerrainCollision(collision);
    }
    
    private void CheckTerrainCollision(Collision collision){
        if (collision != null && collision.gameObject.CompareTag(terrainTag)){
            HandleTerrainCollision(collision.gameObject);
        }
    }
    
    private void HandleTerrainCollision(GameObject terrainObject){
        Debug.Log("Collided with terrain: " + terrainObject.name);
        gameObject.SetActive(false);
    }
}
