using UnityEngine;
using System.Collections;

public class MovingEnemies : MonoBehaviour {
    public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goat"))
        {
            other.gameObject.SetActive(false);
        }
    }*/
}
