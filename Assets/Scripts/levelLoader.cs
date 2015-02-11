using UnityEngine;
using System.Collections;

public class levelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void OnePlayer () {
		Application.LoadLevel("_Scene_1Player");
	}

	public void TwoPlayer() {
		Application.LoadLevel("_Scene_2Player");
	}
}
