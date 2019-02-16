using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoSingleton<Director>
{
	private UIManager uiManager;
	private SceneManager sceneManager;


	protected override void Init ()
    {
        DontDestroyOnLoad (this);

        uiManager    = GetComponentInChildren<UIManager>( true );
        sceneManager = GetComponentInChildren<SceneManager>( true );
    }
}
