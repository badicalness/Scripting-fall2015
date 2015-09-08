using UnityEngine;
using System.Collections;

public class Variablesandfunctions : MonoBehaviour
{   
	int number = 10;
	
	
	void Start ()
	{
		number = MultiplyByTwo(number);
		Debug.Log (number);
	}
	
	
	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
