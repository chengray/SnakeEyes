using UnityEngine;
using System.Collections;

public class foodSpawner2 : MonoBehaviour {
	public GameObject foodPrefab;

	public Transform top;
	public Transform bot;
	public Transform left;
	public Transform right;
	public static bool eaten = true;

	// Use this for initialization
	void Start () {
		Instantiate(foodPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		eaten = false;
	}

	void FixedUpdate(){
		if (eaten) {
			Spawn();
		}
	}

	void Spawn() {
		int xcoord = (int)Random.Range (left.position.x + 0.5f, right.position.x - 0.5f);
		int ycoord = (int)Random.Range (top.position.y - 0.5f, bot.position.y + 0.5f);

		Instantiate(foodPrefab, new Vector3(xcoord, ycoord, 0), Quaternion.identity);
		eaten = false;
	}
}
