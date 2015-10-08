using UnityEngine;
using System.Collections;

public class AnotherShoe
{
	public int heals;
	public int bananas;
	
	
	private int stapler;
	private int sellotape;
	
	
	public void ShoeStore (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Fruit total: " + answer);
	}
	
	
	private void OfficeSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Office Supplies total: " + answer);
	}
}