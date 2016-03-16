#pragma strict

var enemy1 : GameObject;
var enemy2 : GameObject;

function Start () {
	InvokeRepeating("SpawnEnemy", 1, 2);	
}

function SpawnEnemy () {
	var rand : int = Random.Range (1, 3);
	var xPos : float = Random.Range (-3.0, 3.0);
	var pos : Vector3 = Vector3 (xPos, transform.position.y, transform.position.z);
	
	switch (rand) {
	case 1:
		Instantiate (enemy1, pos, Quaternion.identity);
		break;
	case 2:
		Instantiate (enemy2, pos, Quaternion.identity);
		break;
	}
}