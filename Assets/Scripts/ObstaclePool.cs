using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
	public float minY = -3f;
	public float maxY = 1.5f;

	private float backgroundLength;
	

	// Use this for initialization
	void Awake ()
	{
		backgroundLength = 3.5f;
		RepositionBackground();
	}
	
	// Update is called once per frame
	void Update () {
		
		// If this object has fully scrolled
		if (transform.position.x < -backgroundLength - 2)
		{
			// Reposition the background to the future step
			RepositionBackground();
		}
	}

	void RepositionBackground()
	{
		var currentPosition = transform.position;

		// Reposition to X offset
		currentPosition.x = transform.position.x + backgroundLength * 3;

		// Update Y coordinate
		currentPosition.y = Random.Range(minY, maxY);

		// Apply position
		transform.position = currentPosition;
	}
}
