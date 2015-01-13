using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PhysicsEngine : MonoBehaviour {
	public float mass = 1f;
	public Vector3 velocityVector;  // average velocity this FixedUpdate()
	public Vector3 netForceVector;
	public List<Vector3> forceVectorList = new List<Vector3>();

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		AddForces ();
		UpdateVelocity ();
		// Update position
		transform.position += velocityVector * Time.deltaTime;
	}
	
	void AddForces () {
		netForceVector = Vector3.zero;
		
		foreach (Vector3 forceVector in forceVectorList) {
			netForceVector = netForceVector + forceVector;
		}
	}
	
	void UpdateVelocity () {
		Vector3 accelerationVector = netForceVector / mass;
		velocityVector += accelerationVector * Time.deltaTime;
	}
}
