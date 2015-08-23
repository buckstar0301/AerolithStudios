using UnityEngine;
using System.Collections;

public class WheelRotation : MonoBehaviour {

	public GameObject WheelLeft;
	public GameObject WheelRight;
	public bool gravityDown;
	public float wheelSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		WheelLeft.transform.Rotate (Vector3.left, wheelSpeed * Time.deltaTime * 360);
		WheelRight.transform.Rotate (Vector3.right * wheelSpeed * Time.deltaTime * 360);

//		
	}
}
