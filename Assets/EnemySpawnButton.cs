using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnButton : MonoBehaviour
{
    private bool playerDetect = false;
    public GameObject enemy;
    

    void Update()
    {
        if (playerDetect && Input.GetKeyDown(KeyCode.E))
        {
            GameObject child = GameObject.Instantiate(enemy);
            child.transform.position = Vector2.zero;
            child.SetActive(true);
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player 1")
        {
            playerDetect = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerDetect = false;
    }
}
