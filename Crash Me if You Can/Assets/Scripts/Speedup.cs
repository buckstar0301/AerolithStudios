using UnityEngine;
using System.Collections;

public class Speedup : MonoBehaviour {

	public float speed;
	private Stats statList;


	// Use this for initialization
	void Start () {
		statList = GameObject.Find ("GM").GetComponent<Stats>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("4") && statList.speedUpCount > 0) {
//			print ("Triggered SPeed up");
			statList.planeSpeed = statList.planeSpeed * speed;
			statList.speedUpCount--;
		}
		else if(Input.GetKeyDown ("5") && statList.slowDownCount > 0) {
//			print("Slowing");
			statList.planeSpeed = statList.planeSpeed/2;
			statList.slowDownCount--;
	}
}
}