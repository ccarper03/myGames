using UnityEngine;
using System.Collections;

public class DestroyBasicDelay : MonoBehaviour {

	void Update ()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			Destroy(gameObject,3f);
		}
	}
}
