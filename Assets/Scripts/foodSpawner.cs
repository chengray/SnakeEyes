using UnityEngine;
using System.Collections;

public class foodSpawner : MonoBehaviour {
	public GameObject foodPrefab;
	public static bool eaten = true;

	// Use this for initialization
	void Start () {
	}

	void FixedUpdate(){
		if (eaten) {
			Spawn();
		}
	}

	void Spawn() {
		int xcoord = (int)Random.Range (-25f, 25f);
		int ycoord = (int)Random.Range (-20f, 20f);

		Instantiate(foodPrefab, new Vector3(xcoord, ycoord, 0), new Quaternion(45f, 45f, 45f, 0));
		eaten = false;
	}
}
