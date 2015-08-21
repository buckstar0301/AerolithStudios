using UnityEngine;
using System.Collections;

public class PlaneMover : MonoBehaviour {

	public float speed;
	public float respawnTrigger;
	public float respawnDist;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += Vector3.forward * -speed;

		if (transform.position.z < respawnTrigger) {
			transform.position -= Vector3.forward * respawnDist;
		}

	
	}
}
