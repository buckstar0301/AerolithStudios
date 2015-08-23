using UnityEngine;
using System.Collections;

public class cameraSwitch : MonoBehaviour {
	public Stats playerStats;
	// Use this for initialization
	void Start () {
		playerStats = GameObject.Find ("GM").GetComponent<Stats>();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerStats.cameraFlipCount > 0) {

		if (Input.GetKeyDown ("1")) {
			transform.Rotate (0, 0 * Time.deltaTime, 90);
				playerStats.cameraFlipCount--;
		} else if (Input.GetKeyDown ("e")) {
			transform.Rotate (0, 0 * Time.deltaTime, -90);
		}
	}
	}
}
