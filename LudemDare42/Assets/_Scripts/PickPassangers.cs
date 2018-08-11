using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPassangers : MonoBehaviour {

	public int maxPassengerCount = 6; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
	}
}
