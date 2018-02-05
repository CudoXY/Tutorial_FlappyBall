using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollableObject : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		// Stop scrolling on game over
		if (GameMechanicHandler.Instance.IsGameOver)
			return;

		// Move the attached object opposite to the target direction
		var currentPosition = (Vector2) this.transform.position;
		var nextPosition = new Vector2(-GameMechanicHandler.Instance.ScrollSpeed * Time.deltaTime, 0);
		
		// Update the position of the attached object
		this.transform.position = currentPosition + nextPosition;
	}
}
