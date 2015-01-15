using UnityEngine;
using System.Collections;

[RequireComponent (typeof(PhysicsEngine))]
public class RocketEngine : MonoBehaviour {
	
	public float fuelMass;				// [kg]
	public float maxThrust;				// kN [kg m s^-2]
	
	[Range (0, 1f)]	
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
		if (fuelMass > FuelThisUpdate()) {
			fuelMass -= FuelThisUpdate();
			physicsEngine.mass -= FuelThisUpdate();
			ExertForce ();
		} else {
			Debug.LogWarning ("Out of rocket fuel");
		}
	}	
	
	float FuelThisUpdate () {							// [
		float exhaustMassFlow;							// [
		float effectiveExhastVelocity;					// [
		
		effectiveExhastVelocity = 4462f;				// [m s^-1]  liquid H O
		exhaustMassFlow = currentThrust / effectiveExhastVelocity;		
			
		return exhaustMassFlow * Time.deltaTime;
	}
	
	void ExertForce () {
		currentThrust = thrustPercent * maxThrust * 1000f;
		Vector3 thrustVector = thrustUnitVector.normalized * currentThrust;  // N
		physicsEngine.AddForce (thrustVector);
	}
}