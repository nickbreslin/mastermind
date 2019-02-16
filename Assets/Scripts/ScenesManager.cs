using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesManager : MonoSingleton<ScenesManager>
{
	void OnEnable() {
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnDisable() {
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {

		if( scene.buildIndex == 0 ){
			LoadMainMenu();
		}

		//
		// TODO: Set UI Manager state on each scene load
		//

	}

	public void LoadMainMenu() {
		SceneManager.LoadScene("MainMenu");
	}
}
