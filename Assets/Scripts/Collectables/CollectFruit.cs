using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectFruit : MonoBehaviour
{

    public AudioSource coinFX;
    public int rotateSpeed = 1;

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        this.gameObject.SetActive(false);
        // Add to the player's score
        GameManager.inst.IncrementScore();
    }

    private void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}