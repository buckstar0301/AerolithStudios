using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 

public class Tokens : MonoBehaviour {
	public Text countText;
	public Text winText;
	public Stats statList;
	private int count;

	// Use this for initialization
	void Start () 
	{
		SetCountText ();
		count = 0;
		SetCountText ();
		winText.text = "";

		statList = GameObject.Find ("GM").GetComponent<Stats>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Player")) {

			statList.playerScore += 1;
			print("Collided");
			SetCountText ();
		}
	}
		void SetCountText()
		{
		countText.text = "Anal Beads:" + count.ToString ();
	}
}
