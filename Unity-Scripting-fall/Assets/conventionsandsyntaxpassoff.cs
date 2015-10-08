using UnityEngine;
using System.Collections;

public class conventionsandsyntaxpassoff : MonoBehaviour

{
	void Start ()
	{

	}
	void update ()
	{

		Debug.Log (transform.position.y);


		if (transform.position.y <= 10)
		{
			Debug.Log ("I'm going to splater!");
		}
	}
}

