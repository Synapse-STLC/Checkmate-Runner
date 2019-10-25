using UnityEngine;

public class followPlayer : MonoBehaviour
{
    //Get a reference to our player object
    //Note: we need to to this manually
    public Transform player;

    //Make and offset for the camera to be outside of our player object
    public Vector3 cameraOffset;

    // Update is called once per frame
    void Update()
    {
        //Change the position of the camera to be the same as the player + the offset
        transform.position = player.position + cameraOffset;
    }
}
