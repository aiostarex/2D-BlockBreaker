﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private bool hasStarted = false;
	
	public Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		//
		if(!hasStarted)
		{
			// 
			this.transform.position = paddle.transform.position + paddleToBallVector;
				
			// Fare tıklamasını bekle	
			if(Input.GetMouseButtonDown(0))
			{
				print("Mouse click detected, launch ball");
				hasStarted=true;
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
	}

}

	
