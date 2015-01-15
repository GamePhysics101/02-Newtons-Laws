using UnityEngine;
using System.Collections;

[RequireComponent (typeof(PhysicsEngine))]
public class RocketEngine : MonoBehaviour {
	
	public float fuelMass;				// [kg]
	public float maxThrust;				// kN [kg m s^-2]	
	public float thrustPercent;			// [none]
	public Vector3 thrustUnitVector;	// [none]
	
	private PhysicsEngine physicsEngine;

	// Use this for initialization
	void Start () {
		physicsEngine = GetComponent<PhysicsEngine>();
	}
	
	void FixedUpdate () {
		physicsEngine.AddForce (thrustUnitVector);
	}
}