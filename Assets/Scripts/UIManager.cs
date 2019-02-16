using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIState
{
	None,
	MainMenu

}

public class UIManager : MonoSingleton<UIManager>
{
	private UIState uiState;

	protected override void Init ()
    {
        SetUIState( UIState.MainMenu );
    }

    public void isLoaded() {
    	Debug.Log("UI Manager is attached.");
    }

	public void SetUIState( UIState state ) {
		Debug.Log("UI State set to: " + state.ToString());

		uiState = state;
	}

	void OnGUI() {

		switch( uiState ) {

			case UIState.MainMenu:
				RenderMainMenu();
				break;

			default:
				break;
		}
	}



	void RenderMainMenu () {

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();
        
        if( GUILayout.Button("Play") ) {
        	Debug.Log("Play clicked");
        }

        if( GUILayout.Button("How To Play") ) {
        	Debug.Log("How clicked");
        }

        if( GUILayout.Button("Settings") ) {
        	Debug.Log("Settings clicked");
        }
        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
	}
}
