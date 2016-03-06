using UnityEngine;
using System.Collections;

public class ButtonInput : MonoBehaviour {

	void Update ()
	{
		bool down = Input.GetButtonDown("Jump");
		bool held = Input.GetButton("Jump");
		bool up = Input.GetButtonUp("Jump");

		if(down)
		{
			Debug.Log ("button pressed");
		}
		else if(held)
		{
			Debug.Log ("button Held");
		}
		else if(up)
		{
			Debug.Log ("button released");
		}
		else
		{
			Debug.Log ("Nothing is pressed right now");
		}
	}
}
