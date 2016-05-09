using UnityEngine;
using System.Collections;

public class zombieWalk : MonoBehaviour {

	public string zombieMotion;

	// Use this for initialization
	void Start () {
		if (zombieMotion.Length > 0) {
			this.GetComponent<Animator> ().Play (zombieMotion);
		} else {
			this.GetComponent<Animator> ().Play ("attack");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
