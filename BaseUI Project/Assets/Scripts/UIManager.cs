using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public string LevelTag;
    public ScoreManager m_Scores;
    public HealthBars m_Health;
    public UIItems Manager;

    public Transform CreditsMenu;
    public Transform MainMenu;
    public Transform GameWorldUI;
    public Transform DifficultyUI;

    public Text HighScoreNum1;
    public Text HighScoreNum2;
    public Text HighScoreNum3;

    public Text HighScoreValues1;
    public Text HighScoreValues2;
    public Text HighScoreValues3;
    public Text LastScoreVar;

    public Button Player1Loader;
    public Button Player2Loader;
    public Button Player3Loader;
    public Button Player4Loader;
    public Button StartGame;

    public bool PlayerLoaderisActive;
    public bool MenuisActive;
    public bool Easy;
    public bool Medium;
    public bool Hard;

    void Start ()
    {
        Easy = false;
        Medium = false;
        Hard = false;
        MenuisActive = false;
        Time.timeScale = 0.0f;
        m_Scores.m_Pref1st = PlayerPrefs.GetFloat(m_Scores.FirstHighScore);
        m_Scores.m_Pref2nd = PlayerPrefs.GetFloat(m_Scores.SecondHighScore);
        m_Scores.m_Pref3rd = PlayerPrefs.GetFloat(m_Scores.ThirdHighScore);
        m_Scores.m_LastScore = PlayerPrefs.GetFloat(m_Scores.LastScore);
    }

    //-----------------------------------------------------//
    // Credits Area
    public void Credits()
    {
        MainMenu.gameObject.SetActive(false);
        CreditsMenu.gameObject.SetActive(true);
    }
    public void BackToMenu()
    {
        CreditsMenu.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(true);
    }
    //-----------------------------------------------------//
    // Level Loader
    public void LoadLevelEasy()
    {
        if (Manager.PlayerCount >= 1)
        {
            Easy = true;
            Time.timeScale = 1.0f;
            DifficultyUI.gameObject.SetActive(false);
            GameWorldUI.gameObject.SetActive(true);

            m_Health.Player1HealthUpdate();
            m_Health.Player2HealthUpdate();
            m_Health.Player3HealthUpdate();
            m_Health.Player4HealthUpdate();

            m_Scores.m_Score = 0;
        }
    }

    public void LoadLevelMedium()
    {
        if (Manager.PlayerCount >= 1)
        {
            Medium = true;
            Time.timeScale = 1.0f;
            DifficultyUI.gameObject.SetActive(false);
            GameWorldUI.gameObject.SetActive(true);

            m_Health.Player1HealthUpdate();
            m_Health.Player2HealthUpdate();
            m_Health.Player3HealthUpdate();
            m_Health.Player4HealthUpdate();

            m_Scores.m_Score = 0;
        }
    }

    public void LoadLevelHard()
    {
        if (Manager.PlayerCount >= 1)
        {
            Hard = true;
            Time.timeScale = 1.0f;
            DifficultyUI.gameObject.SetActive(false);
            GameWorldUI.gameObject.SetActive(true);

            m_Health.Player1HealthUpdate();
            m_Health.Player2HealthUpdate();
            m_Health.Player3HealthUpdate();
            m_Health.Player4HealthUpdate();

            m_Scores.m_Score = 0;
        }
    }
    //-----------------------------------------------------//
    // Loads The Difficulty UI
    public void DifficultyLoader()
    {
        if (Manager.PlayerCount >= 1)
        {
            MainMenu.gameObject.SetActive(false);
            DifficultyUI.gameObject.SetActive(true);
        }
    }
    //-----------------------------------------------------//
    // Loads Player Loader
    public void PlayerLoader()
    {
        if (PlayerLoaderisActive == false)
        {
            PlayerLoaderisActive = true;
            Player1Loader.gameObject.SetActive(true);
            Player2Loader.gameObject.SetActive(true);
            Player3Loader.gameObject.SetActive(true);
            Player4Loader.gameObject.SetActive(true);
            StartGame.gameObject.SetActive(true);
        }
        else if (PlayerLoaderisActive == true)
        {
            PlayerLoaderisActive = false;
            Player1Loader.gameObject.SetActive(false);
            Player2Loader.gameObject.SetActive(false);
            Player3Loader.gameObject.SetActive(false);
            Player4Loader.gameObject.SetActive(false);
            StartGame.gameObject.SetActive(false);
        }
    }
    //-----------------------------------------------------//
    public void BackToMainMenu()
    {
        DifficultyUI.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadHighScores()
    {
        if (MenuisActive == false)
        {
            MenuisActive = true;
            // High Score Text Loaded
            HighScoreNum1.gameObject.SetActive(true);
            HighScoreNum2.gameObject.SetActive(true);
            HighScoreNum3.gameObject.SetActive(true);
            // High Score Values Loaded
            HighScoreValues1.gameObject.SetActive(true);
            HighScoreValues2.gameObject.SetActive(true);
            HighScoreValues3.gameObject.SetActive(true);
        }
        else if (MenuisActive == true)
        {
            MenuisActive = false;
            // High Score Text UnLoading
            HighScoreNum1.gameObject.SetActive(false);
            HighScoreNum2.gameObject.SetActive(false);
            HighScoreNum3.gameObject.SetActive(false);
            // High Score Values UnLoading
            HighScoreValues1.gameObject.SetActive(false);
            HighScoreValues2.gameObject.SetActive(false);
            HighScoreValues3.gameObject.SetActive(false);
        }
    }

	void Update ()
    {
        HighScoreValues1.text = m_Scores.m_Pref1st.ToString();
        HighScoreValues2.text = m_Scores.m_Pref2nd.ToString();
        HighScoreValues3.text = m_Scores.m_Pref3rd.ToString();
        LastScoreVar.text = m_Scores.m_LastScore.ToString();
    }
}