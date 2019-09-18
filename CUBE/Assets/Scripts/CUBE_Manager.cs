using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE_Manager : MonoBehaviour
{
	public GameObject prefab;
	public int numberOfObjects = 5;
	public float radius = 5f;
	
	

	void Start() 
	{
    	for (int i = 0; i < numberOfObjects; i++) 
		{
        	float angle = i * Mathf.PI * 2 / numberOfObjects;
        	Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
        	var child = Instantiate(prefab, pos, Quaternion.identity);
			child.transform.SetParent(transform);
    	}
	}
}