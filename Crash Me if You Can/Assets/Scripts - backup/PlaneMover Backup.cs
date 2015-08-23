using UnityEngine;
using System.Collections;


public class PlaneMover_Backup : MonoBehaviour {
//
//	/* Prefabs*/
//
//	public GameObject obstacle1;
//	public GameObject obstacle2;
//	public GameObject obstacle3;
//	public GameObject obstacle4;
//	public GameObject obstacle5;
//	public GameObject obstacle6;
//
//	/* End Prefabs*/
//
//	private float RandomZ;
//	public bool enableGeneration;
//	public GameObject parent;
//	public GameObject child;
//	private int obstacleNum;
//	public float speed;
//	public float respawnTrigger;
//	public float respawnDist;
//	private int RandomNum;
//	private int floorNum;
//
//
//	void Start () {
//		floorNum = 1;
//		//print (transform.position);
//		RandomNum = Random.Range (1, 6);
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		transform.position += Vector3.forward * -speed;
//		if (transform.position.z < respawnTrigger) {
//
//			if (enableGeneration == true)
//			Generation();
//
//			if (floorNum == 1) {
//				floorNum = 2;
//			} else if (floorNum == 2)  {
//				floorNum = 3;
//			} else if (floorNum == 3) {
//				floorNum = 4;
//			} else if (floorNum == 4) {
//				floorNum = 1;
//			}
//			transform.position += Vector3.forward * respawnDist;
//		}
//
//	
//
//	
//	}
//
//	void Generation () {
//		Destroy (child);
//		Debug.Log ("generation triggered, " + floorNum);
//		RandomNum = Random.Range (1,6);
//		RandomZ = Random.Range (5, 20);
//		parent = GameObject.Find("Bottom " + floorNum);
//		foreach (Transform childTransform in parent.transform) {
//			//GameObject.Destroy(child.gameObject);
//		}
//		switch (RandomNum) {
//		case 1 :
//			child = Instantiate(obstacle1, new Vector3(-2.5f, 1, RandomZ), obstacle1.transform.rotation) as GameObject;
//			print ("Creating Obstacle 1, my z is" + child.transform.position.z);
//			break;
//		case 2 :
//			child = Instantiate(obstacle2, new Vector3(-3.2f, 1, RandomZ), obstacle2.transform.rotation) as GameObject;
//			print ("Creating Obstacle 2");
//			break;
//		case 3 :
//			child = Instantiate(obstacle3, new Vector3(-2.5f, 1, RandomZ), obstacle3.transform.rotation) as GameObject;
//			print("Creating Obstacle 3");
//			break;
//		case 4 :
//			child = Instantiate(obstacle4,  new Vector3(2.5f, 1, RandomZ), obstacle4.transform.rotation) as GameObject;
//			print ("Creating Obstacle 4");
//			break;
//		case 5 :
//			child = Instantiate(obstacle5, new Vector3(0, 1, RandomZ), obstacle5.transform.rotation) as GameObject;
//			print ("Creating Obstacle 5");
//			break;
//		case 6 :
//			child = Instantiate(obstacle6, new Vector3(2.5f, 1, RandomZ), obstacle6.transform.rotation) as GameObject;
//			print ("Creating Obstacle 6");
//			break;
//		default :
//			print ("There is somethig wrong with the switch/ randomNum");
//			break;
//
//		}
//		Debug.Log("generation complete");
//
//		//child = Instantiate(obstacle1);
//		child.transform.parent = parent.transform;
//
//	}
}
