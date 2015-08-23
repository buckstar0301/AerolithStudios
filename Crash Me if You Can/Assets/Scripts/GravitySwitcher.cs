using UnityEngine;
using System.Collections;

public class GravitySwitcher : MonoBehaviour {

	public bool isGrounded = false;
	public int gravityScale = 3;
	public bool timerStarted = false;
	public playerController playCtrl;

	// Use this for initialization
	void Start () {

		Physics.gravity *= gravityScale;
	
	}

	IEnumerator groundedTimer() {
		yield return new WaitForSeconds (0.1f);
		if ((Physics.Raycast (transform.position, -transform.up, 0.1f)) == true) {
			isGrounded = true;
		}
		timerStarted = false;
	}

	// Update is called once per frame
	void Update () {
		if (isGrounded == false && timerStarted == false) {
			timerStarted = true;
			StartCoroutine ("groundedTimer");
		}

		if ((Input.GetKeyDown ("space")) && (isGrounded == true) && (timerStarted == false)) {
			Physics.gravity *= -1;
			isGrounded = false;
		}
	}

}
