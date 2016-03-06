using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{

	//Member variables can be referred to as
	//fields.
	private int experience;

	//Experience is a basic property
	public int Experience 
	{
		get 
		{
			//Some other code
			return experience;
		}
		set 
		{
			//Some other code
			experience = value;
		}
	}

	//Level is a property that converts experience
	//points into the leve of a player automatically
	public int Level
	{
		get
		{
			return experience / 1000;
		}
		set
		{
			experience = value * 1000;
		}
 	}
}
