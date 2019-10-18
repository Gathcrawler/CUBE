using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesMover : MonoBehaviour 
{
	public float Speed = 10;
	public List<GameObject> MovingCubes = new List<GameObject>();

	
	public void Initialisation(List<GameObject> cubes)
	{
		Select(cubes);
	}

	public void Select(List<GameObject> selectedCubes)
	{
		MovingCubes.Clear();
		MovingCubes.AddRange(selectedCubes);

	}
	private void FixedUpdate()
	{
		
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 destinationVector = Vector3.zero;
			
			if (moveHorizontal > 0)
			{
				destinationVector = transform.right * Time.deltaTime * Speed;
			}
			else if (moveHorizontal < 0)
			{
				destinationVector = -transform.right * Time.deltaTime * Speed;
			}
		

			if (moveVertical > 0)
			{
				destinationVector = transform.forward * Time.deltaTime * Speed;
			}
			else if (moveVertical < 0)
			{
				destinationVector = -transform.forward * Time.deltaTime * Speed;
			}

			// moving time
			foreach (GameObject cube in MovingCubes)
				{
					cube.transform.Translate(destinationVector);
				}

	}
}