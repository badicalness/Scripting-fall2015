using UnityEngine;
using System.Collections;

public class forloop : MonoBehaviour
{
	int countToTen = 10;
	
	
	void Start ()
	{
		for(int i = 0; i < countToTen; i++)
		{
			Debug.Log("Counting to Ten: " + i);
		}
	}
}