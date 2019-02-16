using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoSingleton<SceneManager>
{
	private UIManager uiManager;


	protected override void Init ()
    {
        DontDestroyOnLoad (this);

        uiManager = GetComponentInChildren<UIManager>( true );
        uiManager.isLoaded();
    }
}
