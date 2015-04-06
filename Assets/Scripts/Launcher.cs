using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	public float maxLaunchSpeed;
	public AudioClip windUpSound, launchSound;
	public PhysicsEngine ballToLaunch;

	public float launchSpeed;
	private AudioSource audioSource;
	private float extraSpeedPerFrame;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = windUpSound; // So we know the length of the clip
		extraSpeedPerFrame = (maxLaunchSpeed * Time.fixedDeltaTime) / audioSource.clip.length;
	}

	void OnMouseDown () {
		// Increase ball speed to max over a few seconds
		// Consdider InvokeRepeating
		launchSpeed = 0;
		InvokeRepeating ("IncreaseLaunchSpeed", 0.5f, Time.fixedDeltaTime);
		audioSource.clip = windUpSound;
		audioSource.Play ();
	}

	void OnMouseUp () {
		CancelInvoke ();

		audioSource.Stop ();
		audioSource.clip = launchSound;
		audioSource.Play ();

		PhysicsEngine newBall = Instantiate (ballToLaunch) as PhysicsEngine;
		newBall.transform.parent = GameObject.Find ("Launched Balls").transform;
		Vector3 launchVelocity = new Vector3 (1, 1, 0).normalized * launchSpeed;
		newBall.velocityVector = launchVelocity;
	}

	void IncreaseLaunchSpeed () {
		if (launchSpeed <= maxLaunchSpeed) {
			launchSpeed += extraSpeedPerFrame;
		}
	}
}