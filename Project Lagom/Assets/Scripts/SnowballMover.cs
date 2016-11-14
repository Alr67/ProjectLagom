using UnityEngine;
using System.Collections;

public class SnowballMover : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}