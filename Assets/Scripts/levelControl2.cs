using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelControl2 : MonoBehaviour {
	Text gt;
	// Use this for initialization
	void Start () {
		gt = this.GetComponent<Text> ();
		StartCoroutine(CountDown());
	}
	
	// Update is called once per frame
	void Update () {
		if (p1Control.dead) {
			if(p2Control.dead){
				gt.text = "Tie Game";
				StartCoroutine(MainMenu());
			}
			else{
				gt.text = "You Win!";
				StartCoroutine(MainMenu());
			}
		}
		else if(p2Control.dead){
			gt.text = "You Lose!";
			StartCoroutine(MainMenu());
		}
	}

	IEnumerator MainMenu() {
		yield return new WaitForSeconds(2f);
		Application.LoadLevel("_Scene_0Start");
	}

	IEnumerator CountDown(){
		gt.text = "3";
		yield return new WaitForSeconds(1f);
		gt.text = "2";
		yield return new WaitForSeconds(1f);
		gt.text = "1";
		yield return new WaitForSeconds(1f);
		p1Control.start = true;
		p2Control.start = true;
		gt.text = "GO!";
		yield return new WaitForSeconds(1f);
		gt.text = "";
	}
}
