using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelName : MonoBehaviour {
    public Text LevelText;

	
	// Update is called once per frame
	void Update () {
        LevelText.text = SceneManager.GetActiveScene().name;

    }
}
