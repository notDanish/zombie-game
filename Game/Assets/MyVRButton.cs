using UnityEngine;
using System.Collections;

public class MyVRButton : MonoBehaviour {
	public string triggerCall;

	void Start() {
	}

	public void OnGazeEnter() {
		Debug.Log ("HIII");
	}

	public void OnGazeExit() {
		Debug.Log ("BYEE");
	}

	public void trigger() {
		Debug.Log ("YOLO");
		if (triggerCall.Length == 0) {
			
		} else {
			GetComponent<Animator> ().Play (triggerCall);
		}
	}
}
