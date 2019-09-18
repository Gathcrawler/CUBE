﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE_Manager : MonoBehaviour {

	public GameObject prefab;
	public int numberOfObjects = 6;


	void Start() 
	{
    	for (int i = 0; i < numberOfObjects; i++) 
		{
        	float angle = i * Mathf.PI * 2 / numberOfObjects;
        	Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle));
        	Instantiate(prefab, pos, Quaternion.identity);
    	}
	}
}