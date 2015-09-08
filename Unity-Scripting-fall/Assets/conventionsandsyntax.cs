using UnityEngine;
using System.Collections;

public class conventionsandsyntax : MonoBehaviour
{
	void Start ()
	{
		Debug.Log(transform.position.x);
		
		if(transform.position.y <= 5f)
		{
			Debug.Log ("Here we go again!");
		}
	}
}