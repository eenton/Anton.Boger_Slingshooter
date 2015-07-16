using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// Audio
	private AudioSource source;
	public AudioClip ExplosionSound;

	void Awake(){

		source = GetComponent<AudioSource> ();

	}


	// A static field visible from anywhere
	public static bool goalMet = false;

	void OnTriggerEnter(Collider other) {
		// Check if the hit comes from a projectile
		if(other.gameObject.tag == "Projectile") {
			goalMet = true;


			// Set alpha to higher opacity
			Color c = GetComponent<Renderer>().material.color;
			c.a = 1.0f;
			GetComponent<Renderer>().material.color = c;

		}
	}

	void Update() {

		if (goalMet == true) {
			source.PlayOneShot (ExplosionSound);

		}
	
	}
}
