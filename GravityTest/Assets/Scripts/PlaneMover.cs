using UnityEngine;
using System.Collections;


public class PlaneMover : MonoBehaviour {

	/* Prefabs*/

	public GameObject obstacle1;
	public GameObject obstacle2;
	public GameObject obstacle3;
	public GameObject obstacle4;
	public GameObject obstacle5;
	public GameObject obstacle6;

	/* End Prefabs*/
	private float RandomZ;
	public bool enableGeneration;
	public GameObject parent;
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
		RandomNum = Random.Range (1, 6);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * -speed;
		if (transform.position.z < respawnTrigger) {

			if (enableGeneration == true)
			Generation();

			if (floorNum == 1) {
				floorNum = 2;
			} else  {
				floorNum = 1;
			}
			transform.position += Vector3.forward * respawnDist;
			print ("trigger" + RandomNum);
		}

	

	
	}

	void Generation () {
		RandomNum = Random.Range (1, 6);
		RandomZ = Random.Range (1,2);
		Destroy(child);
		parent = GameObject.Find("Bottom " + floorNum);
		switch (RandomNum) {
		case 1 :
			child = Instantiate(obstacle1/*, new Vector3(-2.5f, 1, RandomZ), Quaternion.identity*/);
			print ("Creating Obstacle 1");
			break;
		case 2 :
			child = Instantiate(obstacle2);
			print ("Creating Obstacle 2");
			break;
		case 3 :
			child = Instantiate(obstacle3);
			print("Creating Obstacle 3");
			break;
		case 4 :
			child = Instantiate(obstacle4);
			print ("Creating Obstacle 4");
			break;
		case 5 :
			child = Instantiate(obstacle5);
			print ("Creating Obstacle 5");
			break;
		case 6 :
			child = Instantiate(obstacle6);
			print ("Creating Obstacle 6");
			break;
		default :
			print ("There is somethig wrong with the switch/ randomNum");
			break;
		
		}


		//child = Instantiate(obstacle1);
		child.transform.parent = parent.transform;

	}
}
