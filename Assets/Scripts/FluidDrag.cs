using UnityEngine;
using System.Collections;

public class FluidDrag : MonoBehaviour {

	[Range (1, 2f)]
	public float velocityExponent;		// [none]
	public float dragConstant;			// ??
	
	private PhysicsEngine physicsEngine;
	
	// Use this for initialization
	void Start () {
		physicsEngine = GetComponent<PhysicsEngine>();
	}
	
	void FixedUpdate () {
		Vector3	velocityVector = physicsEngine.velocityVector;
		float speed = velocityVector.magnitude;
		float dragSize = CalculateDrag (speed);
		Vector3 dragVector = dragSize * -velocityVector.normalized;
		
		physicsEngine.AddForce (dragVector);
	}

	float CalculateDrag (float speed) {
		return dragConstant * Mathf.Pow (speed, velocityExponent);
	}
}
