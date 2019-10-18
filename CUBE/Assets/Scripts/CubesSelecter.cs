using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesSelecter : MonoBehaviour 
{
    public Material selectedmaterial;
	public Material unselectedmaterial;
	public List<GameObject> SelectedCubes = new List<GameObject>();

	
	public void Initialisation(List<GameObject> cubes)
	{
		Select(cubes);
	}

	public void Select(List<GameObject> cubesToSelect)
	{
        foreach (GameObject cube in SelectedCubes)
        {
            cube.GetComponent<Renderer>().material = unselectedmaterial;
        }
		SelectedCubes.Clear();
		SelectedCubes.AddRange(cubesToSelect);
        foreach (GameObject cube in cubesToSelect)
		{
			cube.GetComponent<Renderer>().material = selectedmaterial;
		}
	}

    public void UnSelect(List<GameObject> cubesToUnSelect)
    {
        cubesToUnSelect.Clear();

    }
}
