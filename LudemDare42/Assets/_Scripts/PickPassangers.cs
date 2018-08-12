using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPassangers : MonoBehaviour {

	public int maxPassengerCount;
	public int PassengerCount;
	private UIManager _uIManager;

	// Use this for initialization
	void Start () {
		_uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        
	}
    
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Passanger"){
			if (PassengerCount < maxPassengerCount)
            {
                PassengerCount++;
				_uIManager.setMaxPassengers(PassengerCount, maxPassengerCount);
                Destroy(other.gameObject);
            }
		}

		if(other.tag == "goal"){
			PassengerCount = 0;
			Debug.Log(PassengerCount);
		}


	}
}
