using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
	Text gt;

	void Start () {
		gt = this.GetComponent<Text> ();
		StartCoroutine(CountDown());
	}

	IEnumerator CountDown(){
		gt.text = "3";
		yield return new WaitForSeconds(1f);
		gt.text = "2";
		yield return new WaitForSeconds(1f);
		gt.text = "1";
		yield return new WaitForSeconds(1f);
		p1Control.start = true;
		gt.text = "GO!";
		yield return new WaitForSeconds(1f);
		gt.text = "";
	}
}
