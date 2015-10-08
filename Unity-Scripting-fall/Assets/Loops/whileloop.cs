using UnityEngine;
using System.Collections;

public class whileloop : MonoBehaviour
{
	int mintsInMyPurse = 10;


	void Start ()
	{
		while(mintsInMyPurse > 0)
		{
			Debug.Log ("I've found another mint!");
			mintsInMyPurse--;
		}
	}
}
