﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomAI : MonoBehaviour {

	public Transform target; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
		transform.Translate(Vector3.forward * Time.deltaTime);
        
	}
}
