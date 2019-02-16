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
        SetUIState( UIState.None );
    }

    public void isLoaded() {
    	Debug.Log("UI Manager is attached.");
    }

	public void SetUIState( UIState state ) {
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
		
	}
}
