using UnityEngine;
using System.Collections;

public class MovingEnemies : MonoBehaviour {
    private float speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(1.8f,5.1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Goat").GetComponent<GoatScript>().lifePointsChecker() && GameObject.Find("Goat").GetComponent<GoatScript>().keepSpawning())
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag("Snowball")) {
			Destroy(other.gameObject);
			Destroy (gameObject);
        }
	}
}
