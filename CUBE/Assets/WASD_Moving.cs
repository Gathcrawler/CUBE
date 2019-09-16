using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Moving : MonoBehaviour 
{

	public float Speed = 10;
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