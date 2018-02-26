using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGameManager : MonoBehaviour
{
    public UIManager MainManager;
    public HealthBars HealthManager;
    public ScoreManager m_Scores;

    public Transform MainMenuLoad;
    public Transform MainCanvas;
    public Transform DeadScene;
    
    public bool m_isDead;
    public bool isPaused;

    void Start ()
    {
        isPaused = false;
        m_isDead = false;
    }

    //-----------------------------------------------------//
    // Loads Main Menu
    public void LoadMainMenu()
    {
        DeadScene.gameObject.SetActive(false);
        MainCanvas.gameObject.SetActive(false);
        MainMenuLoad.gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        m_isDead = false;
    }
    // Exit Game Fully
    public void ExitGame()
    {
        Application.Quit();
    }
    // If Dead Trigger This
    public void Dead()
    {
        if (m_isDead == true)
        {
            MainCanvas.gameObject.SetActive(false);
            DeadScene.gameObject.SetActive(true);
            m_Scores.UpdateGameScores();
            // Inputing Base Health For Reset
            HealthManager.Player1Health = 100;
            HealthManager.Player2Health = 100;
            HealthManager.Player3Health = 100;
            HealthManager.Player4Health = 100;

            MainManager.Easy = false;
            MainManager.Medium = false;
            MainManager.Hard = false;

            Time.timeScale = 0.0f;
        }
    }
    //-----------------------------------------------------//
    // Pause Option
    public void Pause()
    {
        if (isPaused == false)
        {
            isPaused = true;
            Time.timeScale = 0.0f;
        }
        else if (isPaused == true)
        {
            isPaused = false;
            Time.timeScale = 1.0f;
        }
    }
    // Option To Leave MidGame
    public void MainMenuMidGame()
    {
        //MainCanvas.gameObject.SetActive(false);
        //MainMenuLoad.gameObject.SetActive(true);
        //Time.timeScale = 0.0f;
        //m_Scores.m_Score = 0;
        //MainManager.Easy = false;
        //MainManager.Medium = false;
        //MainManager.Hard = false;

        SceneManager.LoadScene("PlayScene");
    }
    //-----------------------------------------------------//

    void Update ()
    {
        if (HealthManager.Player1Health == 0 || HealthManager.Player1Health == 0 || HealthManager.Player1Health == 0 || HealthManager.Player1Health == 0)
        {
            m_isDead = true;
            Dead();
        }
        //  Kills The Game - Set Bool To Death Bool 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_isDead = true;
            Dead();
        }
    }
}