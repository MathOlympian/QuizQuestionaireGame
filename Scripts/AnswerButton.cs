using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnswerButton : MonoBehaviour 
{
	public Text answerText;
	private AnswerData answerData;
	private GameController gameController;

	// Use this for initialization
	void Start () 
	{
		gameController = FindObjectOfType<GameController> ();
	}
	
	// Update is called once per frame
	public void Setup (AnswerData data) 
	{
		answerData = data;
		answerText.text = answerData.answerText;
	}

	public void HandleClick()
	{
		gameController.AnswerButtonClicked (answerData.isCorrect);
	}
}
