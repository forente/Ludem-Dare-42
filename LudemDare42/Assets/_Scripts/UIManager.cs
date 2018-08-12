using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {

	public GameObject passengerCount;
	public TextMeshProUGUI countText;
	public int maxCount;


	// Use this for initialization
	void Start () {
		passengerCount = GameObject.Find("Pcount text");
		countText = passengerCount.GetComponent<TextMeshProUGUI>();
        
	}

	// Update is called once per frame
	void Update () {
		//countText.text = "Updated test";
	}
    
	public void setMaxPassengers(int count, int maxCount){
		
		countText.text = "Passengers: "+count+" / " + maxCount;
	}


}
