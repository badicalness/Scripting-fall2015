using UnityEngine;
using System.Collections;

public class dowhileloop : MonoBehaviour 
{
	void Start()
	{
		bool possibleContinuation = false;
		
		do
		{
			print ("Here it is.");
			
		}while(possibleContinuation == true);
	}
}