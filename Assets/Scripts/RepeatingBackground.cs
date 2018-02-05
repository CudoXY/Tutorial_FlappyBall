using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

	private float backgroundLength;

	// Use this for initialization
	void Awake ()
	{
		var spriteRenderer = this.GetComponent<SpriteRenderer>();
		backgroundLength = spriteRenderer.sprite.bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		
		// If this object has fully scrolled
		if (transform.position.x < -backgroundLength)
		{
			// Reposition the background to the future step
			RepositionBackground();
		}
	}

	void RepositionBackground()
	{
		// Move 2 lengths forward
		var offset = new Vector2(backgroundLength * 2f, 0);
		this.transform.position = (Vector2) transform.position + offset;
	}
}
