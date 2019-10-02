using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesMover : MonoBehaviour 
{
	public float Speed = 10;
	public List<GameObject> MovingCubes = new List<GameObject>();
	
	public void Start()
	{
		foreach (Transform child in this.gameObject.transform)
		{
			MovingCubes.Add(child.gameObject);
		}
	}


	private void FixedUpdate()
	{
		
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
			
			if (moveHorizontal > 0)
			{
				transform.Translate(transform.right * Time.deltaTime * Speed);
			}
			else if (moveHorizontal < 0)
			{
				transform.Translate(-transform.right * Time.deltaTime * Speed);
			}
		

			if (moveVertical > 0)
			{
				transform.Translate(transform.forward * Time.deltaTime * Speed);
			}
			else if (moveVertical < 0)
			{
				transform.Translate(-transform.forward * Time.deltaTime * Speed);
			}

	}
}