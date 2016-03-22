using UnityEngine;
using System.Collections;

public class MainMenuFunctions : MonoBehaviour 
{
	public void BtnPlayClick()
	{
		Application.LoadLevel("Quanternions");
	}
	public void BtnOptionsClick()
	{
		Application.LoadLevel("Menu_Options");
	}
	public void BtnCreditsClick()
	{
		Application.LoadLevel("GetButton and GetKey");
	}
	public void BtnExitClick()
	{
		Application.LoadLevel("MouseClick");
	}
}
