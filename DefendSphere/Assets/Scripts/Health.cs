using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public GameObject panelGO;
    public Image heart1, heart2, heart3;
    public int healthStructer;
    public void Start()
    {
        //Instantiate(heart1,heart1.transform.position,Quaternion.identity);
        //Instantiate(heart2, heart2.transform.position,Quaternion.identity);
        //Instantiate(heart3, heart3.transform.position,Quaternion.identity);
        heart1.enabled = true;
        heart2.enabled = true;
        heart3.enabled = true;
        

    }
    public void Update()
    {
        if (GameManager.Instance.health > 3)
        {
            GameManager.Instance.health = 3;
        }
        healthStructer = GameManager.Instance.health;
        



        switch (healthStructer)
        {
            case 3:

                heart1.enabled = true;
                heart2.enabled = true;
                heart3.enabled = true;
                break;
            case 2:
                heart1.enabled = true;
                heart2.enabled = true;
                heart3.enabled = false;
                break;
            case 1:
                heart1.enabled = true;
                heart2.enabled = false;
                heart3.enabled = false;
                
                break;
            case 0:
                heart1.enabled = false;
                heart2.enabled = false;
                heart3.enabled = false;
                Time.timeScale = 0;
                GameManager.Instance._gameState = GameManager.GameState.Gameover;
                panelGO.SetActive(true);
                break;
        }
    }
    

}
