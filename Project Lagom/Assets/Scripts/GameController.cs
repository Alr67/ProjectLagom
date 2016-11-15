using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject vandalPrefab;
    public Vector3 rightSpawningVector;
    public Vector3 leftSpawningVector;
    // Use this for initialization
    void Start () {
        StartCoroutine(spawnVandals());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator spawnVandals() {
        while (true) {
            Instantiate(vandalPrefab, rightSpawningVector, Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }
    }
    //test
}
