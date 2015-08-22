using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 

public class Tokens : MonoBehaviour {
	public Text countText;
//	public Text winText;

	private int count;

	// Use this for initialization
	void Start () 
	{
		SetCountText ();
		count = 0;
		SetCountText ();
//		winText.text = "";
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Player")) {
			//other.gameObject.SetActive (false);
			count = count + 1;
			print("Collided");
			SetCountText ();
		}
	}
		void SetCountText()
		{
		countText.text = "Count:" + count.ToString ();
	}
}
