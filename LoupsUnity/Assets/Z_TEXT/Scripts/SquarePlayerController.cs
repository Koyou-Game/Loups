using UnityEngine;
using System.Collections;

public class SquarePlayerController : MonoBehaviour
{
	private KeyboardInputController inputController;
	// Use this for initialization
	void Start ()
	{
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

	}
}
