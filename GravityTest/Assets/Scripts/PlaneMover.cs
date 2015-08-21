using UnityEngine;
using System.Collections;


public class PlaneMover : MonoBehaviour {

	public GameObject parent;
	public GameObject obstacle;
	public GameObject child;
	private int obstacleNum;
	public float speed;
	public float respawnTrigger;
	public float respawnDist;
	private int RandomNum;
	private int floorNum;


	void Start () {
		floorNum = 1;
		print (transform.position);
		RandomNum = Random.Range (1, 2);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * -speed;
		if (transform.position.z < respawnTrigger) {
			Destroy(child);
			if (floorNum == 1) {
				floorNum = 2;
			} else  {
				floorNum = 1;
			}
			transform.position += Vector3.forward * respawnDist;
			parent = GameObject.Find("Bottom " + floorNum);
			child = Instantiate(obstacle);
			child.transform.parent = parent.transform;


			print ("trigger" + RandomNum);
		}

	
	}
}
