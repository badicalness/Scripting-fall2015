using UnityEngine;
using System.Collections;

public class Enumberation : MonoBehaviour 
{
	enum Direction{Up, Down, Left, Right};void Start () 
	{
		Direction myDirection;
		
		myDirection = Direction.Up;
	}
	
	Direction ReverseDirection (Direction dir)
	{
		if(dir == Direction.Up)
			dir = Direction.Left;
		else if(dir == Direction.Left)
			dir = Direction.Up;
		else if(dir == Direction.Down)
			dir = Direction.Right;
		else if(dir == Direction.Right)
			dir = Direction.Down;
		
		return dir;     
	}
}