using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class p1Control : MonoBehaviour {
	public GameObject tailPrefab;
	public float moveDelay = 0.05f;
	public static bool dead = false;
	public static bool start = false;

	Vector3 direction = Vector3.right;
	List<Transform> tail = new List<Transform>();
	float timeToGo;
	bool inAir = false;
	bool eat = false;
	int count = 0;

	// Use this for initialization
	void Start () {
		timeToGo = Time.fixedTime + moveDelay;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("d")){
			this.transform.Rotate(new Vector3(0, 0, 90f));
		}
		if(Input.GetKeyDown("a")){
			this.transform.Rotate(new Vector3(0, 0, -90f));
		}
		if(Input.GetKeyDown("w") && tail.Count > 2 && !inAir){
			Vector3 loc = this.transform.position;
			loc.z = 1;
			this.transform.position = loc;
			inAir = true;
			count = 0;
		}
		if(Input.GetKeyDown("s") || (count == 3)){
			Vector3 loc = this.transform.position;
			loc.z = 0;
			this.transform.position = loc;
			inAir = false;
		}
		if(Time.fixedTime >= timeToGo && !dead && !p2Control.dead && start){
			Move();
			timeToGo = Time.fixedTime + moveDelay;
		}
	}

	void Move(){
		Vector3 pos = this.transform.position;

		this.transform.Translate(direction);

		if (eat) {
			GameObject gOb = (GameObject)Instantiate(tailPrefab, pos, Quaternion.identity);
			tail.Insert(0, gOb.transform);
			eat = false;
		}
		else if(tail.Count > 0){
			tail.Last().position = pos;
			tail.Insert(0, tail.Last());
			tail.RemoveAt(tail.Count-1);
		}
		count++;
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "foodPrefab(Clone)") {
			eat = true;
			Score.score += 10;
			foodSpawner.eaten = true;
			Destroy(other.gameObject);
		}
		else {
			dead = true;
		}
	}
}
