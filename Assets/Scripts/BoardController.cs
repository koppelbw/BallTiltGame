using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour {

	public float resetSpeed;
	public float rotationSpeed;
	Quaternion origin = Quaternion.Euler (0, 0, 0);


	void Start () {
		resetSpeed = 1.0f;
		rotationSpeed = 0.5f;
	}

	void Update () {

		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		Vector3 rotate = new Vector3(moveX, 0.0f, moveY);

		transform.Rotate (-Input.GetAxis ("Vertical") * rotationSpeed, 0.0f, -Input.GetAxis ("Horizontal") * rotationSpeed);

	}

	public void resetBoard() {

		//this.transform.rotation = Quaternion.Slerp (this.transform.rotation, origin, Time.deltaTime * resetSpeed);
		this.transform.rotation = new Quaternion (0, 0, 0, 0);
	}

}