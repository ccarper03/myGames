#pragma strict

function Update () {
	if (Input.GetKey (KeyCode.LeftArrow) ) {
		transform.Translate(Vector3.left * Time.deltaTime * 4);
	}
	if (Input.GetKey (KeyCode.RightArrow) ) {
		transform.Translate(Vector3.right * Time.deltaTime * 4);
	}
	if (Input.GetKey (KeyCode.UpArrow) ) {
		transform.Translate(Vector3.up * Time.deltaTime * 4);
	}
	if (Input.GetKey (KeyCode.DownArrow) ) {
		transform.Translate(Vector3.down * Time.deltaTime * 4);
	}
}