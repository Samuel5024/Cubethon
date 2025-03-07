using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //reference to the Player's rigidbody coomponent
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
void FixedUpdate() //use fixed update for physics stuff
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.deltaTime is the amount of time since computer drew the last frame

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
