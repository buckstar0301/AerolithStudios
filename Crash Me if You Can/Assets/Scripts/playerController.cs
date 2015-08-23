using UnityEngine;
using System.Collections;

public class playerControllerold1: MonoBehaviour {

	public float rotationSpeed;
	public GravitySwitcher gravSwitcher;
	public Stats statList;
	public bool isSwitching = false;
	Vector3 gravDown;
	Quaternion target;
	private float timeStartedLerping;
	public float distanceToMove;
	private int direction;
	public bool isLerping;
	Vector3 startPos;
	Vector3 endPos;
	public float timeTakenDuringLerp = 4f;
	float YposLast;


	// Use this for initialization
	void Start () {
		gravDown = Physics.gravity.normalized;
		endPos = transform.position;
		statList = GameObject.Find ("GM").GetComponent<Stats>();
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown("2")&& statList.inverseControlCount >0)
		{
			print ("Switch triggered");
			isSwitching = true;
		}
		YposLast = transform.position.y;

		if (isLerping == false) {
			transform.position = new Vector3 (endPos.x, YposLast, endPos.z);
		}

		if (Physics.gravity.normalized != gravDown) {
			target = Quaternion.Euler (0, 0, 180);
		} else {
			target = Quaternion.identity;
		}

		transform.rotation = Quaternion.Lerp (transform.rotation, target, Time.deltaTime * rotationSpeed);

		if (gravSwitcher.isGrounded == true) {

			float keyInput = Input.GetAxisRaw ("Horizontal");

			if (statList.controlInverted = true) { // Currently being worked on.
				keyInput *= -1;
			}

			if (keyInput < 0 && (transform.position.x < 2.5) && (isLerping == false) && (statList.inverseControlCount >= 1)){
				direction = 1;
				startLerping ();
				//isSwitching = false;
				print ("swithced");
			} else if (keyInput > 0 && (transform.position.x > -2.5) && (isLerping == false)) {
				direction = 0;
				startLerping ();
			}
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

			Vector3 lerPos = Vector3.Lerp ( startPos, endPos, percentageComplete);
			transform.position = new Vector3 (lerPos.x, YposLast, lerPos.z);

			if(percentageComplete >= 1.0f)
			{
				isLerping = false;
			}
		}
	}
}			                                
