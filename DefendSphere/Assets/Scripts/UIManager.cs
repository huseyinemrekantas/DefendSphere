using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject panelGO;
    public GameObject buttonStart;
    
    void Awake()
    {
        Time.timeScale = 0;
    }

    public void StartButton()
    {
        GameManager.Instance._gameState = GameManager.GameState.Play;
        buttonStart.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReGame()
    {
        GameManager.Instance._gameState = GameManager.GameState.Play;
        Time.timeScale = 1;
        panelGO.SetActive(false);
        buttonStart.SetActive(false);
        GameManager.Instance.health = 3;

    }

    


}
