using UnityEngine;
using System.Collections;

public class classes : MonoBehaviour
{
	public class Stuff
	{
		public int needles;
		public int thread;
		public int fabric;
		
		public Stuff(int nee, int thr, int fab)
		{
			needles = nee;
			thread = thr;
			fabric = fab;
		}
	}
	
	
	public Stuff myStuff = new Stuff(10, 7, 25);
	public float speed;
	public float turnSpeed;
	public Rigidbody needlePrefab;
	public Transform threadPosition;
	public float needleSpeed;
	
	
	void Update ()
	{
		Movement();
		Shoot();
	}
	
	
	void Movement ()
	{
		float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
		
		transform.Translate(Vector3.forward * forwardMovement);
		transform.Rotate(Vector3.up * turnMovement);
	}
	
	
	void Shoot ()
	{
		if(Input.GetButtonDown("Fire1") && myStuff.needles > 0)
		{
			Rigidbody bulletInstance = Instantiate(needlePrefab, threadPosition.position, threadPosition.rotation) as Rigidbody;
			bulletInstance.AddForce(threadPosition.forward * needleSpeed);
			myStuff.needles--;
		}
	}
}