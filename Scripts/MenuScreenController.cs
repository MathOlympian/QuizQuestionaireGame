using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuScreenController : MonoBehaviour {

	// Use this for initialization
	public void StartGame () 
	{
		SceneManager.LoadScene ("Game");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
