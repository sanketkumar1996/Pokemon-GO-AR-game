using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pokemon2Script : MonoBehaviour {
	public Button attackButton2;
	public GameObject spawnPoint; 
	public GameObject fireBall;
	// Use this for initialization
	void Start () {
		attackButton2.onClick.AddListener (attackButton2Down);
	}
	void attackButton2Down(){
		fireBall = Instantiate (Resources.Load ("fireMobile"), spawnPoint.transform.position, Quaternion.identity) as GameObject;
		fireBall.GetComponent<Rigidbody>().AddRelativeForce(spawnPoint.transform.forward * -1000f );
		Destroy (fireBall, 2);
	}   
	
	// Update is called once per frame
	void Update () {
	
	}
}
