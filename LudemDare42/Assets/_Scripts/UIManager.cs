using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {

	TextMeshPro passengerCountText;
	public int maxCount;


	// Use this for initialization
	void Start () {
		passengerCountText = GameObject.Find("PCount").GetComponent<TextMeshPro>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setMaxPassengers(int count){
		maxCount = count;
		passengerCountText.text = "Passengers: 0 / " + maxCount;
	}


}
