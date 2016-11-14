using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ThrowScript : MonoBehaviour {

	public Button yourButton;
	public GameObject snowball;
	private GameObject arrow;
	private float arrowDirection;
	private Vector3 throwDirection;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		arrow = GameObject.FindGameObjectWithTag("Arrow");
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Instantiate(snowball, arrow.transform.position, arrow.transform.rotation);


	}
}