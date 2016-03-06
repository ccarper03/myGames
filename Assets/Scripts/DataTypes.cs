using UnityEngine;
using System.Collections;

public class DataTypes : MonoBehaviour  
{

	void Start () 
	{
		//Changing the value by using a reference type variable

		//Value type variable
		Vector3 pos = transform.position;
		//pos = new Vector3(0, 2, 0);

		//Reference type variable
		Transform tran = transform;
		tran.position = new Vector3(0, 2, 0);
	}
}
