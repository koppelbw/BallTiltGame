using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public GameController gameController;
	public GameObject ballPrefab;

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
		this.transform.position = new Vector3 (7.5f, 2.0f, 7.139f);
		this.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
	}
}
