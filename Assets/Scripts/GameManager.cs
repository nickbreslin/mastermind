using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    void Start() {
        GameObject go = new GameObject();
        SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = Resources.Load("Minions/Minion_Fox", typeof(Sprite)) as Sprite;

//        go.AddComponent<>();
    }
}
