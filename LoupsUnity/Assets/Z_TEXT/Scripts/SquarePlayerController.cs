using UnityEngine;
using System.Collections;

public class SquarePlayerController : MonoBehaviour
{
	private Rigidbody2D rd2d;
	private KeyboardInputController inputController;
	// Use this for initialization
	void Start ()
	{
		rd2d = GetComponent<Rigidbody2D> ();
		inputController = GetComponent<KeyboardInputController> ();

		inputController.SetCallback (
			HandleCallMove
		);
	}


	void FixedUpdate ()
	{


	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void HandleCallMove (float horizontal, float vertical)
	{
		Debug.Log ("horizontal:" + horizontal + " vertical:" + vertical);
		rd2d.velocity = rd2d.velocity + new Vector2 (horizontal, vertical);
	}
}
