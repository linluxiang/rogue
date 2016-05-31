using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	public GameObject gameObject;

	void Awake() {
		if (GameManager.instance == null) {
			Debug.LogFormat ("init gameobject");
			Instantiate (gameObject);
		}
	}
}
