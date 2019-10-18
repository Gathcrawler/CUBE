using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE_Manager : MonoBehaviour
{
	public GameObject prefab;
	public CubesMover cubesMover;
	public CubesSelecter cubesSelecter;
	public int numberOfObjects = 5;
	public float radius = 5f;
	public bool selectable = false;
	public List<GameObject> cubes;
	
	void Start() 
	{
		cubes = new List<GameObject>();
    	for (int i = 0; i < numberOfObjects; i++) 
		{
        	float angle = i * Mathf.PI * 2 / numberOfObjects;
        	Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
			var child = Instantiate(prefab, pos, Quaternion.identity);
			child.transform.SetParent(transform);
			cubes.Add(child);
    	}
		
		cubesMover.Initialisation(new List<GameObject>());
		cubesSelecter.Initialisation(new List<GameObject>());
	}
	
	void Update ()
    {
     	if (Input.GetMouseButtonDown(0))
     	{
        	Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				List<GameObject> allcubes = new List<GameObject>();
				allcubes.Add(hit.collider.gameObject);
				cubesMover.Select(allcubes);
				cubesSelecter.Select(allcubes);
			}
			else
			{
				cubesMover.Select(new List<GameObject>());
				cubesSelecter.Select(new List<GameObject>());
			}
     	}
    }   			
}