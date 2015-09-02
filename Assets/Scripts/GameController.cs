using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int lives;
	private int round;
	public BoardController boardController;
	public BallController ballController;

	// Use this for initialization
	void Start () {
		lives = 3;
		round = 1;
		boardController = GameObject.FindGameObjectWithTag ("Ground").GetComponent<BoardController> ();
		ballController = GameObject.FindGameObjectWithTag ("Ball").GetComponent<BallController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void resetRound() {
		boardController.resetBoard ();
		ballController.resetBall ();
	}

	public void roundWin() {
		Debug.Log ("WINNER");
		round ++;
		resetRound ();
	}

	public void GameOver() {
		Debug.Log ("GAME OVER");
		lives += 3;
		resetRound ();
	}

	public void Death() {
		Debug.Log ("Death, Lives Remaining: " + lives);
		lives--;

		if (lives < 0) {
			resetRound ();
		} else {
			GameOver ();
		}
	}

	public void addLife() {
		Debug.Log ("1 UP, Lives Remaining: " + lives);
		lives++;
	}
}
