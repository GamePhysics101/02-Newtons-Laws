using UnityEngine;
using System.Collections;

[RequireComponent (typeof(PhysicsEngine))]
public class RocketEngine : MonoBehaviour {
	
	public float fuelMass;				// [kg]
	public float maxThrust;				// kN [kg m s^-2]	
	public float thrustPercent;			// [none]
	public Vector3 thrustUnitVector;	// [none]
	
	private PhysicsEngine physicsEngine;
	private float currentThrust;		// N  <- Note Newtons NOT kN

	// Use this for initialization
	void Start () {
		physicsEngine = GetComponent<PhysicsEngine>();
		physicsEngine.mass += fuelMass;
	}
	
	void FixedUpdate () {
		// If there's enough fuel to burn for a full Time.deltaTime
		if (fuelMass > FuelThisUpdate()) {
			fuelMass -= FuelThisUpdate();
			physicsEngine.mass -= FuelThisUpdate();
			ExertForce ();
		} else {
			Debug.LogWarning ("Out of rocket fuel");
		}
	}	
	
	float FuelThisUpdate () {				// [kg]
		float exhaustMassFlow;				// [kg s^-1]
		float effectiveExhastVelocity;		// [m s^-1]
		
		effectiveExhastVelocity = 4462f;	// Liquid HO engine
		
		// thrust = massFlow * exhaustVelocity
		// massFlow = thrust / exhaustVelocity
		exhaustMassFlow = currentThrust / effectiveExhastVelocity;				// [kg]
		return exhaustMassFlow * Time.deltaTime;
	}
	
	void ExertForce () {
		currentThrust = thrustPercent * maxThrust * 1000f;
		Vector3 thrustVector = thrustUnitVector * currentThrust;  // kN
		physicsEngine.AddForce (thrustVector);
	}
}