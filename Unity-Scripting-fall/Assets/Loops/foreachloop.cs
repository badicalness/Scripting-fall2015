using UnityEngine;
using System.Collections;

public class foreachloop : MonoBehaviour 
{   
	void Start () 
	{
		string[] strings = new string[3];
		
		strings[0] = "Thing One";
		strings[1] = "Thing Two";
		strings[2] = "And Thing Three";
		
		foreach(string item in strings)
		{
			print (item);
		}
	}
}