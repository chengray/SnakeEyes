using UnityEngine;
using System.Collections;

public class ballControl : MonoBehaviour {
	public float speed = 2.0f;
	public float smooth = 2.0f;



	// Use this for initialization
	void Start () {
		rigidbody.AddForce(2, 1, 0);
	}

	void FixedUpdate(){

	}

}
