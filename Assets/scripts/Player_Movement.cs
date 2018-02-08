using UnityEngine;

public class Player_Movement : MonoBehaviour {
    // This is a reference to the Rigidbody component called rb
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewayForce = 500f;
    
    // Whenever use physic system, use fixed update
	void FixedUpdate ()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") && Time.deltaTime != 0 )
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") && Time.deltaTime != 0 )
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -0.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
