using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;

public class ifstatement : MonoBehaviour
{
	public float bathTemperature = 96.0f;
	public float hotLimitTemperature = 105.0f;
	public float coldLimitTemperature = 85.0f;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		bathTemperature -= Time.deltaTime * 5f;
	}
	
	
	void TemperatureTest ()
	{
		// If the bath water temperature is greater than the hottest temperature...
		if(bathTemperature > hotLimitTemperature)
		{
			// ... do this.
			print("This bath water is too hot.");
		}
		// If it isn't, but the bath water temperature is less than the coldest temperature...
		else if(bathTemperature < coldLimitTemperature)
		{
			// ... do this.
			print("This bath water is too cold.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("This bath water is perfect.");
		}
	}
}
