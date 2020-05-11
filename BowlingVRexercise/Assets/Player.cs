using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{ 
	public GameObject sphere;
	public float sphereDistance = 2.5f;
	public float sphereThrowForce = 200f;

	public bool hold = true;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (hold)
		{
			sphere.transform.position = transform.position + transform.forward * sphereDistance;

			if (GvrViewer.Instance.Triggered || Input.GetKeyDown("space"))
			{
				hold = false;
				sphere.GetComponent<Rigidbody>().useGravity = true;
				sphere.GetComponent<Rigidbody>().AddForce(transform.forward * sphereThrowForce);
			}
		}
	}
}
