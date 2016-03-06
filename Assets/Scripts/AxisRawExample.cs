using UnityEngine;
using System.Collections;

public class AxisRawExample : MonoBehaviour {
	// for 2d platformer , procise controls , does not require gravity or sensitivity
	public float range;

	void Update () 
	{
		float h = Input.GetAxisRaw("Horizontal");
		float xPos = h * range;

		transform.position = new Vector3(xPos, 2f, 0);  
		string stuff = "Value Returned: "+h.ToString("F2");  
		Debug.Log (stuff);
	}
}
