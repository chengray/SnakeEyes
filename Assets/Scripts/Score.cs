using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	static public int score = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Text gt = this.GetComponent<Text> ();
		gt.text = "Score: " + score;
		if(score > PlayerPrefs.GetInt ("rHighScore")){
			PlayerPrefs.SetInt("HighScore", score);
		}
		if (p1Control.dead == true) {
			gt.text = "Game Over";
		}
	}


}
