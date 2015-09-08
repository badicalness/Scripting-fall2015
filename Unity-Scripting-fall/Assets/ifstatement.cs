using UnityEngine;
using System.Collections;

public class ifstatement : MonoBehaviour
{
	float chocolateTemperature = 85.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		chocolateTemperature -= Time.deltaTime * 5f;
	}
	
	
	void TemperatureTest ()
	{
		// If the hot chocolates's temperature is greater than the hottest drinking temperature...
		if(chocolateTemperature > hotLimitTemperature)
		{
			// ... do this.
			print("Hot Chocolate is too hot.");
		}
		// If it isn't, but the hot chocolate temperature is less than the coldest drinking temperature...
		else if(chocolateTemperature < coldLimitTemperature)
		{
			// ... do this.
			print("Hot Chocolate is too cold.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("Hot Chocolate is just right.");
		}
	}
}