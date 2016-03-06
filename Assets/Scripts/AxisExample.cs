using UnityEngine;
using System.Collections;

public class AxisExample : MonoBehaviour {

	public float range;

	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		float xPos = h * range;

		transform.position = new Vector3(xPos, 2f, 0);
		string stuff = "Value Returned: "+h.ToString("F2");  
		Debug.Log (stuff);
	}
}
