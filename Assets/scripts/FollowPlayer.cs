using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        if (!float.IsNaN(player.position.x) && !float.IsNaN(player.position.y) && !float.IsNaN(player.position.z))
        {
            //Do stuff
            transform.position = player.position + offset;
        }
        
	}
}
