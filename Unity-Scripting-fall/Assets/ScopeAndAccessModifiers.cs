using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
	public int boots = 5;
	
	
	private int beta = 0;
	private int gamma = 5;
	
	
	private AnotherShoe myOtherShoe;
	
	
	void Start ()
	{
		boots = 29;
		
		myOtherShoe = new AnotherShoe();
		myOtherShoe.ShoeStore(boots, myOtherShoe.heals);
	}
	
	
	void Example (int sneakers, int flats)
	{
		int answer;
		answer = sneakers* flats * boots;
		Debug.Log(answer);
	}
	
	
	void Update ()
	{
		Debug.Log("boots is set to: " + boots);
	}
}