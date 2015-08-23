using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	void Start () {
		Application.LoadLevel ("Scene01");
	}

	void loadLevel() {
		Application.LoadLevel ("Scene01");
	}
}
