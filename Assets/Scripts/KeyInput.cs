using UnityEngine;
using System.Collections;

public class KeyInput : MonoBehaviour {

	void Update ()
	{
		bool down = Input.GetKeyDown(KeyCode.Space);
		bool held = Input.GetKey(KeyCode.Space);
		bool up = Input.GetKeyUp(KeyCode.Space);

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
