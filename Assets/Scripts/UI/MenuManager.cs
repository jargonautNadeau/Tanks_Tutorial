using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public void LaunchLocalLobby(){
		
		SceneManager.LoadScene ("TwoPlayerLobby");
	}

	public void LaunchOnlineLobby(){
		SceneManager.LoadScene ("OnlineLobby");
	}

	public void ExitGame(){
		Application.Quit ();
	}
	public void StartLocalGame(){
		SceneManager.LoadScene ("main");
	}
	public void BackToMainMenu(){
		SceneManager.LoadScene ("Menu");
	}
}
