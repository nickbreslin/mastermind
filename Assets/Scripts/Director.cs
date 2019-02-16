using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoSingleton<Director>
{
	private UIManager uiManager;
	private ScenesManager scenesManager;


	protected override void Init ()
    {
        DontDestroyOnLoad (this);

        uiManager    = GetComponentInChildren<UIManager>( true );
        scenesManager = GetComponentInChildren<ScenesManager>( true );
    }
}
