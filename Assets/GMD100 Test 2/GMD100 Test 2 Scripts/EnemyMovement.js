#pragma strict

function Update () {
	transform.Translate (Vector3.down * Time.deltaTime);
}