using UnityEngine;
using System.Collections;

public class FloorColliderScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag("Snowball")) {
			Destroy(other.gameObject);

		}
	}
}
