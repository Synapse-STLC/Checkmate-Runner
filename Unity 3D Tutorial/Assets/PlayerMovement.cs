using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Initialize our constant forces for movement
    public float fowardForce = 1000f;
    public float horizontalForce = 50f;

    //Rigidbody components are in charge of interacting
    //with physics like gravity and other forces
    private Rigidbody rb;

    void Start()
    {
        //Inside of our game object (self), find a component called Rigidbody and assign it to rb
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Continue moving foward our object
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);
        
       //Check fo player input:
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Push player to the right 
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Push player to the left 
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
