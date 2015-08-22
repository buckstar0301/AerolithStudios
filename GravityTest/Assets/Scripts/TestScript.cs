using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	public float speed;

	Vector3 gravDown;
	Quaternion target;

	// Use this for initialization
	void Start () {
		gravDown = Physics.gravity.normalized;
	}
	
	// Update is called once per frame
	void Update () {


		if (Physics.gravity.normalized != gravDown) {// && (transform.position.y > 2.0f)) {
			target = Quaternion.Euler (0, 0, 180);
		} else {
			target = Quaternion.identity;
		}


		transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * speed);


//		if (Input.GetKeyDown("i")) {
//			GetComponent<Rigidbody>().constraints |=  RigidbodyConstraints.FreezePositionX;
//		}
//		if (Input.GetKeyDown ("u")) {
//			GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionX;
//		}

//		print (GetComponent<Rigidbody> ().transform.position);

		if (Input.GetKeyDown ("left")) {

			if (transform.position.x > -3) {
				transform.position += new Vector3 (-3.5f, 0, 0);
			}
		}
		if (Input.GetKeyDown ("right")) {
			
			if (transform.position.x < 3) {
				transform.position += new Vector3 (3.5f, 0, 0);
			}
		}

	}
}
