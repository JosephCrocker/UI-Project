using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float m_Score;
    string m_ScoreHolder;

    public Text textUpdate;
    public UIGameManager UIManager;
    
    // PlaceHolder Values
    float PlaceHolderScore1st;
    float PlaceHolderScore2nd;
    float PlaceHolderScore3rd;
    // Player Pref Keys
    public string FirstHighScore;
    public string SecondHighScore;
    public string ThirdHighScore;
    // Player Pref Saves
    public float m_Pref1st;
    public float m_Pref2nd;
    public float m_Pref3rd;
    // Last Score Variables
    public string LastScore;
    public float m_LastScore;
    float PlaceHolderLastScore;

    void Start ()
    {
        // Player Prefs Value Holders
        m_Pref1st = PlayerPrefs.GetFloat(FirstHighScore);
        m_Pref2nd = PlayerPrefs.GetFloat(SecondHighScore);
        m_Pref3rd = PlayerPrefs.GetFloat(ThirdHighScore);
        m_LastScore = PlayerPrefs.GetFloat(LastScore);
        // Player Pref String Sets
        FirstHighScore = "Score Value 1st";
        SecondHighScore = "Score Value 2nd";
        ThirdHighScore = "Score Value 3rd";
        LastScore = "Your Last Score";
        m_Score = 0;
	}

    public void UpdateGameScores()
    {
        if (UIManager.m_isDead == true)
        {
            if (m_Score > PlaceHolderScore1st && m_Score > m_Pref1st)
            {
                if (m_Pref1st > 0)
                {
                    PlaceHolderScore3rd = m_Pref2nd;
                    PlayerPrefs.SetFloat(ThirdHighScore, PlaceHolderScore3rd);
                    PlaceHolderScore2nd = m_Pref1st;
                    PlayerPrefs.SetFloat(SecondHighScore, PlaceHolderScore2nd);
                    m_Pref3rd = PlaceHolderScore3rd;
                    m_Pref2nd = PlaceHolderScore2nd;
                    PlayerPrefs.Save();
                }
                // Saving Score Using Player Prefs
                PlaceHolderScore1st = m_Score;
                m_Pref1st = PlaceHolderScore1st;
                PlayerPrefs.SetFloat(FirstHighScore, PlaceHolderScore1st);

                // Saving Last Score
                PlaceHolderLastScore = m_Score;
                m_LastScore = PlaceHolderLastScore;
                PlayerPrefs.SetFloat(LastScore, PlaceHolderLastScore);
                PlayerPrefs.Save();
            }
            else if (m_Score > PlaceHolderScore2nd && m_Score > m_Pref2nd)
            {
                if (m_Pref2nd > 0)
                {
                    PlaceHolderScore3rd = m_Pref2nd;
                    PlayerPrefs.SetFloat(ThirdHighScore, PlaceHolderScore3rd);
                    m_Pref3rd = PlaceHolderScore3rd;
                    PlayerPrefs.Save();
                }
                // Saving Score Using Player Prefs
                PlaceHolderScore2nd = m_Score;
                m_Pref2nd = PlaceHolderScore2nd;
                PlayerPrefs.SetFloat(SecondHighScore, PlaceHolderScore2nd);

                // Saving Last Score
                PlaceHolderLastScore = m_Score;
                m_LastScore = PlaceHolderLastScore;
                PlayerPrefs.SetFloat(LastScore, PlaceHolderLastScore);
                PlayerPrefs.Save();
            }
            else if (m_Score > PlaceHolderScore3rd && m_Score > m_Pref3rd)
            {
                // Saving Score Using Player Prefs
                PlaceHolderScore3rd = m_Score;
                m_Pref3rd = PlaceHolderScore3rd;
                PlayerPrefs.SetFloat(ThirdHighScore, PlaceHolderScore3rd);

                // Saving Last Score
                PlaceHolderLastScore = m_Score;
                m_LastScore = PlaceHolderLastScore;
                PlayerPrefs.SetFloat(LastScore, PlaceHolderLastScore);
                PlayerPrefs.Save();
            }
            else
            {
                // Saving Last Score
                PlaceHolderLastScore = m_Score;
                m_LastScore = PlaceHolderLastScore;
                PlayerPrefs.SetFloat(LastScore, PlaceHolderLastScore);
                PlayerPrefs.Save();
            }
            PlayerPrefs.Save();
        }
    }

    void Update ()
    {
        if (UIManager.m_isDead == false)
        {
            m_Score += 1 * Time.deltaTime;
            m_ScoreHolder = m_Score.ToString();
            textUpdate.text = m_ScoreHolder;
        }
    }
}