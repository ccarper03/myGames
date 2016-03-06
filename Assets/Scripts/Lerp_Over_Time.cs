using UnityEngine;
using System.Collections;

public class Lerp_Over_Time : MonoBehaviour {

	// This is a working patrol script.  We will toggle it on and off using the isPatrolling bool.
	public Vector2 myStart;
	public Vector2 myEnd;
	public Vector2[] myPoints;
	public float myMargin;		// myMargin determines how close the patrolling entity needs to get to a patrol point before it can decide that it has arrived
	public float myTime;
	float myTimer;
	int direction = 1;			// direction here is an int, not a float like it was in class.  This seems to be more stable
	public int targetPoint = 0;
	public bool myMode = true;
	public bool isPatrolling = true;

	// Use this for initialization
	void Start () {
		if(myStart == new Vector2(0,0)){
			myStart = transform.position;
			myEnd = myPoints [0];
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(isPatrolling == true){
			myTimer += Time.deltaTime * direction;
			transform.position = Vector2.Lerp(myStart, myEnd, myTimer/myTime);
			if (Vector2.Distance (transform.position, myEnd) < myMargin && direction == 1) {
				PatPath();
			}
		}
	}
	// PatPath manages cycling through the patrol points stored in myPoints[] based on certain criteria. It also allows a point to be specified externally if needed.
	public void PatPath (int NewTargetPoint = -1) {
		if (NewTargetPoint == -1) {
			targetPoint += direction;
			if (targetPoint == myPoints.Length && myMode == true) {
				targetPoint = 0;
			}
			myStart = myEnd;
			myEnd = myPoints [targetPoint];
			myTimer = 0f;

		} else if (NewTargetPoint < myPoints.Length && NewTargetPoint >=0) {
			targetPoint = NewTargetPoint;
			myStart = transform.position;
			myEnd = myPoints [targetPoint];
			myTimer = 0f;
		}

		// these lines cause the patrolling agent to turn and face the point it is patrolling toward
		Quaternion rotation = Quaternion.LookRotation(new Vector3(myEnd.x, myEnd.y, 0f) - transform.position, transform.TransformDirection(Vector3.forward));
		transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
	}
}
