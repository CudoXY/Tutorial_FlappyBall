using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointObject : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		GameMechanicHandler.Instance.AddScore(1);
	}
}
