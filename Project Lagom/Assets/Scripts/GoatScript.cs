using UnityEngine;using UnityEngine.UI;using System.Collections;public class GoatScript : MonoBehaviour {    public int lifePoints;    public Text lifeText;    public Text winLostText;    public Text killedEnemiesText;    public Button restartButton;    public float timeLeft;	// Use this for initialization	void Start () {        lifePoints = 4;        winLostText.enabled = false;        timeLeft = Random.Range(15f, 35f);        killedEnemiesText.text = "Lagom time: " + (int)timeLeft;        restartButton.enabled = false;        restartButton.gameObject.SetActive(false);	}		// Update is called once per frame	void Update () {
        if (lifePointsChecker() && !(timeLeft < 0)) {
            timeLeft -= Time.deltaTime;
            killedEnemiesText.text = "Lagom time: " + (int)timeLeft;
            if (timeLeft < 0)
            {
                winLostText.enabled = true;
                winLostText.text = "Gävlebock protected! ¯\\_(ツ)_/¯";
                restartButton.enabled = true;
                restartButton.gameObject.SetActive(true);
            }
        }
    }    void OnTriggerEnter(Collider other) {        if (other.gameObject.CompareTag("Vandal")) {			Destroy (other.gameObject);            --lifePoints;            lifeText.text = "HP: " + lifePoints.ToString();            if (lifePoints < 2) lifeText.color = Color.red;            if (lifePoints == 0) {				Destroy(gameObject);                winLostText.enabled = true;                winLostText.text = "The Gävlebock burned ¯\\_(ツ)_/¯";                restartButton.enabled = true;                restartButton.gameObject.SetActive(true);            }                    }    }    public bool lifePointsChecker()
    {
        if (lifePoints > 0)
        {
            return true;
        }
        else return false;
    }    public bool keepSpawning()
    {
        if (timeLeft < 0)
        {
            return false;
        }
        else return true;
    }}