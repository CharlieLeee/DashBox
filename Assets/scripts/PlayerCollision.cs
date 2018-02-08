using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Player_Movement movement;

    public AudioSource collide;

    private void Start()
    {
        collide = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if ( collisionInfo.collider.tag == "Obstacle" )
        {
            //Debug.Log("we hit an obstacle");
            GetComponent<Player_Movement>().enabled = false;
            collide.Play();
 
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

}
