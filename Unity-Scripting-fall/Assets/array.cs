using UnityEngine;
using System.Collections;

public class array : MonoBehaviour
{
	public GameObject[] seeds;
	
	void Start ()
	{
		seeds = GameObject.FindGameObjectsWithTag("Seed");
		
		for(int i = 0; i < seeds.Length; i++)
		{
			Debug.Log("Seed Number "+i+" is named "+seeds[i].name);
		}
	}
}