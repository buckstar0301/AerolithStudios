using UnityEngine;
using System.Collections;

public class GravitySwitcher : MonoBehaviour {
	public bool foundHit;
	public Camera MainCam;
	public Rigidbody player;
	public bool isGrounded = false;
	public int gravityScale = 3;
	public bool timerStarted = false;

	private bool passedMidway = true;
	
	// Use this for initialization
	void Start () {

		Physics.gravity *= gravityScale;
	
	}

	IEnumerator groundedTimer() {
		yield return new WaitForSeconds (0.25f);
		if ((Physics.Raycast (transform.position, -transform.up, 0.55f)) == true) {
			isGrounded = true;
		}
		timerStarted = false;
	}

	// Update is called once per frame
	void Update () {

		if (transform.position.y > 3.5f && (transform.position.y < 4.5f)) {
			passedMidway = true;
		}

		Vector3 down = transform.TransformDirection (Vector3.down) * 0.55f;
		Debug.DrawRay (transform.position, down, Color.red);
	

//		if (Physics.Raycast (transform.position, -transform.up, 0.55f)) {
//			isGrounded = true;
//		}

		if ((Input.GetKeyDown ("space")) && (isGrounded == true) && (timerStarted == false)) {

//			groundedTimer();
//			passedMidway = false;
			Physics.gravity *= -1;
			isGrounded = false;
			//player.transform.Rotate (0,0, 180);
			//MainCam.transform.Rotate (0, 0, 180);
//			yield return new WaitForSeconds(1f);
		}
	}

	void FixedUpdate () {
		if (isGrounded == false && timerStarted == false) {
			timerStarted = true;
			StartCoroutine ("groundedTimer");
		}
	}
}
