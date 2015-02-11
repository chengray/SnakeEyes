using UnityEngine;
using System.Collections;

public class levelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		p1Control.dead = false;
		p2Control.dead = false;
		p2Control.start = false;
		p1Control.start = false;
	}
	
	// Update is called once per frame
	public void OnePlayer () {
		Application.LoadLevel("_Scene_1Player");
	}

	public void TwoPlayer() {
		Application.LoadLevel("_Scene_2Player");
	}
}
