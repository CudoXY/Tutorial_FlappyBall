using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	private Rigidbody2D rigidBody;

	public float flapForce;

	// Use this for initialization
	void Start ()
	{
		rigidBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Don't take input when game is over
		if (GameMechanicHandler.Instance.IsGameOver)
			return;

		// Flap when space is pressed
		if (Input.GetKeyDown(KeyCode.Space))
			Flap();
	}

	void Flap()
	{
		// Reset the current velocity
		rigidBody.velocity = Vector2.zero;

		// Add some upward force
		rigidBody.AddForce(new Vector2(0, flapForce));
	}

	void Die()
	{
		// Trigger game over
		GameMechanicHandler.Instance.GameOver();
	}

	void OnCollisionEnter2D()
	{
		Die();
	}
}
