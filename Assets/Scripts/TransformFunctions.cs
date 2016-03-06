using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour {
	// USE THIS EXAMPLE WITH RIGIDBODY THAT IS KINEMATIC
	// anything that is going to use a collider you should use the physics functions instead  
	// you would not use translate or rotate. 
	public float moveSpeed = 10f;
	public float turnSpeed = 200f;
	// Update is called once per frame 
	void Update () 
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
		}
	}
}
