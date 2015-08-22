using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float rotationSpeed;
	
	Vector3 gravDown;
	Quaternion target;
	public float timeStartedLerping;
	public float distanceToMove;
	private int direction;
	public Rigidbody rb;
	public bool isLerping;
	public Vector3 startPos;
	public Vector3 endPos;
	public float timeTakenDuringLerp = 4f;


	// Use this for initialization
	void Start () {
		gravDown = Physics.gravity.normalized;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Physics.gravity.normalized != gravDown) {
			target = Quaternion.Euler (0, 0, 180);
		} else {
			target = Quaternion.identity;
		}

		transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * rotationSpeed);

		if (Input.GetKey ("left") && (transform.position.x > -2.5) && isLerping == false) {
			direction = 0;
			startLerping();

		}
		if (Input.GetKey ("right") && (transform.position.x < 2.5)  && isLerping == false) {

			direction = 1;
			startLerping();
		}





	
	}

	void startLerping() {
		isLerping = true;
		timeStartedLerping = Time.time;
		startPos = transform.position;

		if (direction == 0) {
			endPos = transform.position + Vector3.left * distanceToMove;

		} else if (direction == 1) {
			endPos = transform.position + Vector3.right * distanceToMove;

		}
	}

	void FixedUpdate() {
		if(isLerping)
			{
				float timeSinceStarted = Time.time - timeStartedLerping;
				float percentageComplete = timeSinceStarted / timeTakenDuringLerp;

				transform.position = Vector3.Lerp ( startPos, endPos, percentageComplete);

				if(percentageComplete >= 1.0f)
				{
					isLerping = false;
				}

			
		}
}
			                                   }			                                
