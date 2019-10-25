using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //Variable to reference to our PlayerMovement script
    public PlayerMovement movementScript;
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInformation)
    {
        //Check if we have collided with and object 
        //with a tag saying Obstacle
        if (collisionInformation.collider.tag == "Obstacle")
        {
            //If we collided with and obstacle, then
            //stop player movement by disabling it
            movementScript.enabled = false;
            //Unfreeze the rotation of our object to allow 
            //for interesting impact behavior
            rb.freezeRotation = false;

            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
