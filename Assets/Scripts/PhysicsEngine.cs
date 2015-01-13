using UnityEngine;
using System.Collections;

public class PhysicsEngine : MonoBehaviour {
	public Vector3 velocityVector;  // average velocity this FixedUpdate()

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		transform.position += velocityVector * Time.deltaTime;
	}
}
