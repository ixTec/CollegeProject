﻿using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour {
	
	public Rigidbody rocketPrefab;
	public Transform barrelEnd;
		
		
	void Update ()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Rigidbody rocketInstance;
			rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			rocketInstance.AddForce(barrelEnd.forward * 2000);
		}
	}
}