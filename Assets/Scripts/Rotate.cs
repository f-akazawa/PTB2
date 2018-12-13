using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Rigidbody rbody;
	private float speed;
	private float radius;
	private float yPosition;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
		speed = 1.0f;
		radius = 2.0f;
		yPosition = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {

		rbody.MovePosition(
			new Vector3(
				radius * Mathf.Sin(Time.time * speed),
				yPosition,
				radius * Mathf.Cos(Time.time * speed)
			)
		);
	}
}
