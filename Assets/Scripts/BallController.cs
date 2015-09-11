using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public GameController gameController;
	public GameObject respawn;

	void Start() {
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Ground") {
			gameController.Death();
		}

		if (other.gameObject.tag == "WinZone") {
			gameController.roundWin();
		}
	}

	public void resetBall() {
		this.gameObject.GetComponent<Rigidbody> ().isKinematic = true;
		this.transform.position = respawn.transform.position;
		this.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
	}
}
