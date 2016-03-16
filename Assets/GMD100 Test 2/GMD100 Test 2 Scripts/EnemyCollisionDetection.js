#pragma strict

function OnTriggerEnter (other : Collider) {
	if (other.tag == "Player") {
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}