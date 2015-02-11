using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelControl1 : MonoBehaviour {
	Text gt;
	// Use this for initialization
	void Start () {
		gt = this.GetComponent<Text> ();
		StartCoroutine(CountDown());
	}
	
	// Update is called once per frame
	void Update () {
		if (p2Control.dead) {
			if(p1Control.dead){
				gt.text = "Tie";
				StartCoroutine(MainMenu());
			}
			else{
				gt.text = "You Win!";
				StartCoroutine(MainMenu());
			}
		}
		else if(p1Control.dead){
			gt.text = "You Lose!";
			StartCoroutine(MainMenu());
		}
	}

	IEnumerator MainMenu() {
		yield return new WaitForSeconds(4f);
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
