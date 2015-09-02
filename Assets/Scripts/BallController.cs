using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public GameController gameController;

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
		this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(7.5f, 1.0f, 7.139f), Time.deltaTime * 10);
	}
}
