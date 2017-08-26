using UnityEngine;
using System.Collections;

public class KeyboardInputController : MonoBehaviour
{
	public delegate void CallMove (float horizontal, float vertical);

	private CallMove callMove;

	// Use this for initialization
	void Start ()
	{
	
	}

	void FixedUpdate(){
		float horizontal = 0;  	//Used to store the horizontal move direction.
		float vertical = 0;		//Used to store the vertical move direction.

		horizontal = Input.GetAxisRaw ("Horizontal");
		vertical = Input.GetAxisRaw ("Vertical");

		if (callMove != null) {
			callMove (horizontal, vertical);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public void SetCallback (
		CallMove callMove
	)
	{
		this.callMove = callMove;
	}

	//bleow is example code

	// declare delegate type
	public delegate void WhateverType ();

	// to store the function
	protected WhateverType callbackFct;

	public void something (WhateverType myCallback)
	{  
		callbackFct = myCallback;
	}

	void callProcess ()
	{
		something (dosomething);
	}

	void dosomething ()
	{
		//...
	}
}
