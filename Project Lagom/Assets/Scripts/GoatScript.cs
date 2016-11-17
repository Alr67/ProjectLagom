using UnityEngine;using UnityEngine.UI;using System.Collections;public class GoatScript : MonoBehaviour {    public int lifePoints;    public Text lifeText;    public Text winLostText;    public int killedEnemies;    public Text killedEnemiesText;	// Use this for initialization	void Start () {        lifePoints = 4;        winLostText.enabled = false;        killedEnemies = 0;	}		// Update is called once per frame	void Update () {		}    void OnTriggerEnter(Collider other) {        if (other.gameObject.CompareTag("Vandal")) {			Destroy (other.gameObject);            --lifePoints;            lifeText.text = "HP: " + lifePoints.ToString();            if (lifePoints < 2) lifeText.color = Color.red;            if (lifePoints == 0) {				Destroy(gameObject);                winLostText.enabled = true;                winLostText.text = "Jul was ruined :C";            }                    }    }    public bool lifePointsChecker()
    {
        if (lifePoints > 0) return true;
        else return false;
    }    public void increaseKills()
    {
        ++killedEnemies;
        killedEnemiesText.text = "Avoided trouble: " + killedEnemies.ToString();
        if(killedEnemies == 10)
        {
            winLostText.enabled = true;
            winLostText.text = "You saved the Gävlebock!";
        }
    }    public bool keepSpawning()
    {
        if (killedEnemies < 10) return true;
        else return false;
    }}