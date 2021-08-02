using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;
    public AudioSource audioCoin;
    public GameObject coin;
    

    private void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
        audioCoin.Play();
        Destroy(coin);

 
        if (controller.score % 5 == 0)
        {
            controller.night.SetActive(!controller.night.activeSelf);
     
            controller.day.SetActive(!controller.day.activeSelf);
        }

        

    }

    
}
