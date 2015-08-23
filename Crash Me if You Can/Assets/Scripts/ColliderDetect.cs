using UnityEngine;
using System.Collections;

public class ColliderDetect : MonoBehaviour {
	
	int count;
	private int tokenChooser;

	Rigidbody RB_Main;
	public Rigidbody RB_Body;
	public Rigidbody RB_WheelLeft;
	public Rigidbody RB_WheelRight;
	public Collider Collider_Body;
	public Stats statList;

	public float ExplosionForce;
	public float ExplosionRadius;
	public float InvincibilityDuration = 5f;
	

	 bool invincible = false;

	// Use this for initialization
	void Start () {
		RB_Main = GetComponent<Rigidbody> ();

		RB_Main.isKinematic = false;
		RB_Body.isKinematic = true;
		RB_WheelLeft.isKinematic = true;
		RB_WheelRight.isKinematic = true;
		Collider_Body.isTrigger = true;

		invincible = false;

	
	}
	
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("cameraFlip")) {
			statList.playerScore += 1;
			statList.cameraFlipCount += 1;
			print ("Collided" + statList.playerScore);
			Destroy(other);
		} else if (other.gameObject.CompareTag ("inverseController")) {
			statList.playerScore += 1;
			statList.inverseControlCount += 1;
			Destroy(other);
		} else if (other.gameObject.CompareTag ("Invincible")) {
			StartCoroutine ("triggerInvincible");
			statList.playerScore += 1;
			Destroy(other);
		} else if (other.gameObject.CompareTag ("speedUp")) {
			statList.playerScore += 1;
			statList.speedUpCount += 1;
			Destroy(other);
		} else if (other.gameObject.CompareTag ("slowDown")) {
			statList.playerScore += 1;
			statList.slowDownCount += 1;
			Destroy(other);
		} else if (other.gameObject.CompareTag ("Hazard") && (invincible == true)) {

			RB_Main.isKinematic = true;
			RB_Body.isKinematic = false;
			RB_WheelLeft.isKinematic = false;
			RB_WheelRight.isKinematic = false;

			RB_Body.AddExplosionForce(ExplosionForce, other.transform.position, ExplosionRadius);
			RB_WheelLeft.AddExplosionForce(ExplosionForce, other.transform.position, ExplosionRadius);
			RB_WheelRight.AddExplosionForce(ExplosionForce, other.transform.position, ExplosionRadius);
			Collider_Body.isTrigger = false;
		}

	}

	IEnumerator triggerInvincible () {
		invincible = true;
		yield return new WaitForSeconds (InvincibilityDuration);
		invincible = false;
	}
}
