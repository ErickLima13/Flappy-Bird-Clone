using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject night;
    public GameObject day;
    public GameObject menu;
    public AudioSource music;
    public GameObject pause;
    public GameObject play;
    

    

    private void Start()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
        

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        music.Play();
        
    }

    public void PauseGame()
    {

        Time.timeScale = 0;
        pause.SetActive(true);
        play.SetActive(true);
    }

    public void Continuegame()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
        play.SetActive(false);
    }

    

    private void Update()
    {
        
       
        
        
        
    }
}
