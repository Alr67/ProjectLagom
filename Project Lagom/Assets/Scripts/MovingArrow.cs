using UnityEngine;
using System.Collections;

public class MovingArrow : MonoBehaviour {
    public float speed = 15f;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
