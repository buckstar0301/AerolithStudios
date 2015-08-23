using UnityEngine;
using System.Collections;


public class PlaneMover : MonoBehaviour {

	/* Prefabs*/


	// ################### SOMEONE PLEASE ORGANISE THESE BY NAME FOR THE LOVE OF GOD!!! #######################
	public GameObject obstacle1;
	public GameObject obstacle2;
	public GameObject obstacle3;
	public GameObject obstacle4;
	public GameObject obstacle5;
	public GameObject obstacle6;

	public GameObject token1;
	public GameObject token2;
	public GameObject token3;
	public GameObject token4;
	public GameObject token5;
	public GameObject token6;
	// ########################################################################################################

	/* End Prefabs*/
	public int randomToken;
	public float aha;
//	private int plainChooser; // <-- Not Referenced anywhere (yet?), so commented out to stop console warning msg.
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
	public int randomMax;
	public int randomMin;
	public Quaternion rotation;

	/* Grass Spawning */

	public Vector3 squarePos;  //world position of your square
	public Vector3 squareSize; //x = width, y = height, z = length of box
	public float squareBorder; //how far away from the edges you want the spawn to stay
	Vector3 realSquareSize;
	public GameObject GrassPrefab;
	public float grassDensity = 100;

	void Start () {
		floorNum = 1; // <-- Not ever changed, yet there's a section with if statements depending on this? (Lines 67-74).
		//print (transform.position);
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
			} else if (floorNum == 2)  {
				floorNum = 3;
			} else if (floorNum == 3) {
				floorNum = 4;
			} else if (floorNum == 4) {
				floorNum = 1;
			}
			transform.position += Vector3.forward * respawnDist;
		}

	

	
	}

	void Generation () {
		Destroy (child);
//		Debug.Log ("generation triggered, " + floorNum);
		RandomNum = Random.Range (1,6);
		RandomNum = Random.Range (1,6);
//		plainChooser = Random.Range (1,2);
		RandomZ = Random.Range (randomMin, randomMax);
		parent = GameObject.Find("Bottom " + floorNum);
		foreach (Transform childTransform in parent.transform) { // <-- This creates a value named childTransform which is never used again. Rethink? (it is iterating over all the transforms in 'parent.transforms', but you're not doing anything with the result).
			//GameObject.Destroy(child.gameObject);
		}
		switch (RandomNum) {
		case 1 :
			child = Instantiate(obstacle1, new Vector3(-2.5f, aha, RandomZ), rotation) as GameObject;
//			print ("Creating Obstacle 1, my z is" + child.transform.position.z);
			break;
		case 2 :
			child = Instantiate(obstacle2, new Vector3(-1.2f, aha, RandomZ), rotation) as GameObject;
//			print ("Creating Obstacle 2");
			break;
		case 3 :
			child = Instantiate(obstacle3, new Vector3(-2.5f, aha, RandomZ), rotation) as GameObject;
//			print("Creating Obstacle 3");
			break;
		case 4 :
			child = Instantiate(obstacle4,  new Vector3(2.5f, aha, RandomZ), rotation) as GameObject;
//			print ("Creating Obstacle 4");
			break;
		case 5 :
			child = Instantiate(obstacle5, new Vector3(0, aha, RandomZ), rotation) as GameObject;
//			print ("Creating Obstacle 5");
			break;
		case 6 :
			child = Instantiate(obstacle6, new Vector3(2.5f, aha, RandomZ), rotation) as GameObject;
//			print ("Creating Obstacle 6");
			break;
		default :
//			print ("There is somethig wrong with the switch/ randomNum");
			break;

		}
		switch (randomToken) {
		case 1 :
			child = Instantiate(token1, new Vector3(-2.5f, aha, RandomZ), rotation) as GameObject;
			break;
		case 2 :
			child = Instantiate(token1, new Vector3(0, aha, RandomZ), rotation) as GameObject;
			break;
		case 3 :
			child = Instantiate(token1, new Vector3(1, aha, RandomZ), rotation) as GameObject;
			break;
		case 4 :
			child = Instantiate(token1, new Vector3(-1, aha, RandomZ), rotation) as GameObject;
			break;
		case 5 :
			child = Instantiate(token1, new Vector3(2, aha, RandomZ), rotation) as GameObject;
			break;
		case 6 :
			child = Instantiate(token1, new Vector3(0, aha, RandomZ), rotation) as GameObject;
			break;

		}
//		Debug.Log("generation complete");

		//child = Instantiate(obstacle1);
		child.transform.parent = parent.transform;

	}
}
