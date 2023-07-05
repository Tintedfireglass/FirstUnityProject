
using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo){
        
        if (collisionInfo.collider.tag=="Obstacles"){
            Debug.Log("Obstacle Hit");
            
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}