using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	static public int highscore = 0;

	bool newHigh = false;
	void Awake(){
		if(PlayerPrefs.HasKey("HighScore")){
			highscore = PlayerPrefs.GetInt("HighScore");
		}
		PlayerPrefs.SetInt("HighScore", highscore);
	}

	void Update () {
		Text gt = this.GetComponent<Text> ();
		gt.text = "High Score: " + highscore;
		if (Score.score > highscore) {
			highscore = Score.score;
			PlayerPrefs.SetInt("HighScore", highscore);
			newHigh = true;
		}
		if (p1Control.dead == true) {
			if(newHigh){
				gt.text = "New High Score!";
			}
			StartCoroutine(MainMenu());
		}
	}

	IEnumerator MainMenu() {
		yield return new WaitForSeconds(2f);
		Application.LoadLevel("_Scene_0Start");
	}
}