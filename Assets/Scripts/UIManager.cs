using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	
	public Text gameovertext;
	Canvas canvas;
	CameraController cameraController;

	void Start () {
		canvas = GetComponent<Canvas> ();
		canvas.enabled = false;
		cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
	}

	void Update () {
	
	}

	public void Gameover(){
		gameovertext.text = "GAME\nOVER";
		canvas.enabled = true;
		cameraController.SetGameOver();
	}

	public void Goal(){
		gameovertext.text = "GOAL";
		canvas.enabled = true;
	}
		
	public void Retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void BackTitke()
	{
		SceneManager.LoadScene("Title");
	}

}