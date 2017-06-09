using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour {

	public void Next()
	{
		SceneManager.LoadScene ("Level3J");
	}
}
