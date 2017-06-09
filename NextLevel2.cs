using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour {

	public void Next()
	{
		SceneManager.LoadScene ("Level4J");
	}
}
