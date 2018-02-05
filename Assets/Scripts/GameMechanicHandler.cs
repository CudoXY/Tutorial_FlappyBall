using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMechanicHandler : MonoBehaviour
{
	public float ScrollSpeed = 3f;
	
	public bool IsGameOver;

	public static GameMechanicHandler Instance;

	public int Score;
	public Text ScoreText;

	public GameObject GameOverPanel;

	void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(this.gameObject);
			return;
		}

		Instance = this;
	}

	public void PlayAgain()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void Quit()
	{
		Application.Quit();
	}

	// Use this for initialization
	void Start () {
		AddScore(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int points)
	{
		// Add points to score
		Score = Score + points;

		// Display it to the screen
		ScoreText.text = Score.ToString();
	}

	public void GameOver()
	{
		// Set game over state
		IsGameOver = true;

		// Show game over screen
		GameOverPanel.SetActive(true);
	}
}
