using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public enum GameState { Menu,Play,Gameover }
    public GameState _gameState;

    public int health=3;
    void Start()
    {
        DontDestroyOnLoad(this);
    }

}
