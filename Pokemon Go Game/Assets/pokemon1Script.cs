using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class pokemon1Script : MonoBehaviour {
	public Button attackButton1;
	public GameObject hose;

	// Use this for initialization
	void Start () {
		attackButton1.onClick.AddListener (attackButton1Down);
		hose.transform.FindChild ("WaterShower").gameObject.SetActive (false);
	}
	void attackButton1Down(){

	}
	IEnumerator wait ()
	{
		hose.transform.FindChild ("WaterShower").gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		hose.transform.FindChild ("WaterShower").gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (wait());
	}
}
