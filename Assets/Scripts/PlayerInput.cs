using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	float mxVal = Input.GetAxis("Mouse X");
	float myVal = Input.GetAxis("Mouse Y");

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// M is pressed 
		//if (Input.GetKey(KeyCode.M))
		//{
		//	print ("The 'M' is pressed down");
		//}
		//

		//Reading mouse movement
		if(mxVal != 0)
		{
			print ("Mouse X movement selected: " + mxVal);
		}
		if(myVal != 0)
		{
			print ("Mouse Y movement selected: " + myVal);
		}
	}
}
