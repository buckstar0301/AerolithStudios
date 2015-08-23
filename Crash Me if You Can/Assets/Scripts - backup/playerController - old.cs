//using UnityEngine;
//using System.Collections;
//
//public class playerController-old : MonoBehaviour {
//
//	public float rotationSpeed;
//	public GravitySwitcher gravSwitcher;
//	
//	Vector3 gravDown;
//	Quaternion target;
//	private float timeStartedLerping;
//	public float distanceToMove;
//	private int direction;
//	public bool isLerping;
//	Vector3 startPos;
//	Vector3 endPos;
//	public float timeTakenDuringLerp = 4f;
//	float YposLast;
//
//
//	// Use this for initialization
//	void Start () {
//		gravDown = Physics.gravity.normalized;
//		endPos = transform.position;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//
//		YposLast = transform.position.y;
//
//		if (isLerping == false) {
//			transform.position = new Vector3 (endPos.x, YposLast, endPos.z);
//		}
//
//
//		if (gravSwitcher.isGrounded == true) {
//			if (Input.GetKey ("left") && (transform.position.x > -2.5) && isLerping == false) {
//				direction = 0;
//				startLerping ();
//
//			}
//			if (Input.GetKey ("right") && (transform.position.x < 2.5) && isLerping == false) {
//
//				direction = 1;
//				startLerping ();
//			}
//		}
//	
//	}
//
//	void startLerping() {
//		isLerping = true;
//		timeStartedLerping = Time.time;
//		startPos = transform.position;
//
//		if (direction == 0) {
//			endPos = transform.position + Vector3.left * distanceToMove;
//
//		} else if (direction == 1) {
//			endPos = transform.position + Vector3.right * distanceToMove;
//
//		}
//	}
//
//	void FixedUpdate() {
//
//		if (Physics.gravity.normalized != gravDown) {
//			target = Quaternion.Euler (0, 0, 180);
//		} else {
//			target = Quaternion.identity;
//		}
//		
//		transform.rotation = Quaternion.Lerp (transform.rotation, target, Time.deltaTime * rotationSpeed);
//
//
//		if(isLerping)
//		{
//			float timeSinceStarted = Time.time - timeStartedLerping;
//			float percentageComplete = timeSinceStarted / timeTakenDuringLerp;
//
//			Vector3 lerPos = Vector3.Lerp ( startPos, endPos, percentageComplete);
//			transform.position = new Vector3 (lerPos.x, YposLast, lerPos.z);
//
//			if(percentageComplete >= 1.0f)
//			{
//				isLerping = false;
//			}
//		}
//	}
//}			                                
