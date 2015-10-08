using UnityEngine;
using System.Collections;

public class AnotherShoe
{
	public int heals;
	public int stiletos;
	
	
	private int mascara;
	private int blush;
	
	
	public void ShoeStore (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Shoe total: " + answer);
	}
	
	
	private void MakeupSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("makeup total: " + answer);
	}
}