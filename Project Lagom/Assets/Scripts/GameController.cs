using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject vandalPrefab;
	public float waitTimer;
    public Vector3 rightSpawningVector;
    public Vector3 leftSpawningVector;
	private int sideRandomizer;

    // Use this for initialization
    void Start () {
        StartCoroutine(spawnVandals());
    }

    IEnumerator spawnVandals() {
        while (true && GameObject.Find("Goat").GetComponent<GoatScript>().lifePointsChecker() && GameObject.Find("Goat").GetComponent<GoatScript>().keepSpawning()) {
			sideRandomizer = Random.Range (0, 2);
			if (sideRandomizer == 0) {
				Instantiate (vandalPrefab, leftSpawningVector, Quaternion.Euler (0, 180, 0));
			} else {
				Instantiate (vandalPrefab, rightSpawningVector, Quaternion.Euler (0, 0, 0));
			}
			yield return new WaitForSeconds(waitTimer);
        }
    }
    //test
}
