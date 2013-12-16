using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public static int highscore;
	public TextMesh score;

	// Use this for initialization
	void Start () {
		highscore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Timer.score > highscore) {
			highscore = Timer.score;
		}
		score.text = "Score: " + Timer.score;
	}
}
