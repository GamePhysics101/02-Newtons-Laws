using UnityEngine;
using System.Collections;

public class PhysicsEngine : MonoBehaviour {

	public Vector3 v;  // Average velocity of this FixedUpdate() loop

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate () {
		transform.position += v * Time.deltaTime;
	}
}
