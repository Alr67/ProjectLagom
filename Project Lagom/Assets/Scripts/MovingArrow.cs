using UnityEngine;
using System.Collections;

public class MovingArrow : MonoBehaviour {
    public float speed = 15f;
    public bool right = true;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (right && transform.eulerAngles.y > 120f) {
            right = false;
        }
        else if (!right && transform.eulerAngles.y < 60f) {
            right = true;
        }
        if(!right) transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        else transform.Rotate(-Vector3.forward, speed * Time.deltaTime);
    }
}
