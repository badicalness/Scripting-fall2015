﻿using UnityEngine;
using System.Collections;

public class datatype : MonoBehaviour 
{
	void Start () 
	{
		//Value type variable
		Vector3 pos = transform.position;
		pos = new Vector3(0, 4, 0);
		
		//Reference type variable
		Transform tran = transform;
		tran.position = new Vector3(0, 4, 0);
	}
}