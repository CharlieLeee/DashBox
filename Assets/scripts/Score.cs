using UnityEngine;
using UnityEngine.UI;



public class Score : MonoBehaviour {

    public Transform player;
    public Transform lastObj;
    public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        if (!FindObjectOfType<GameManager>().gameHasEnded && !(player.position.z > lastObj.position.z))
            scoreText.text = player.position.z.ToString("0");
    }
}
