using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Transform target;

	public float easing = 0.125f;
	public Vector3 offset;
	public Vector3 Velocity = Vector3.zero;
	public float rotationSpeed = 5f;


	
	// Update is called once per frame
	void LateUpdate () {

		//Quaternion CamTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed ,Vector3.up);
		//offset = CamTurnAngle * offset;
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref Velocity ,easing);
		transform.position = smoothedPosition;
	}
}
