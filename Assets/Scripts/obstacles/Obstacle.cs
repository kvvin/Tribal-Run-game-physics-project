using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour
{

    PlayerMovement playerMovement;
    public static bool gameOver;
    public GameObject gameOverPanel;

    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Kill the player
            playerMovement.Die();
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            Destroy(gameObject);
        }
  
    }
}

