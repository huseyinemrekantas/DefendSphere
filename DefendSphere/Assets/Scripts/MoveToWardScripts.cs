using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWardScripts : MonoBehaviour
{
    public GameObject player;
    public float speed = 1.0f;
    void Update()
    {
        if (GameManager.Instance._gameState == GameManager.GameState.Play)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), step);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
