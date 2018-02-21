using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIItems : MonoBehaviour
{
    // Holds The Amount Of Players Loaded.
    public int PlayerCount;
    // Bool Checks - Modifys Functions
    public bool Player1Loaded;
    public bool Player2Loaded;
    public bool Player3Loaded;
    public bool Player4Loaded;
    // Toggle Indicates If That Player Has Loaded.
    public Toggle Player1Toggle;
    public Toggle Player2Toggle;
    public Toggle Player3Toggle;
    public Toggle Player4Toggle;
    // Gameobjects Activated
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    void Start()
    {
        Time.timeScale = 0.0f;
        Player1Loaded = false;
        Player2Loaded = false;
        Player3Loaded = false;
        Player4Loaded = false;
    }
    // Loading Player 1
    public void LoadPlayer1()
    {
        if (Player1Loaded == false)
        {
            Player1Loaded = true;
            Player1Toggle.gameObject.SetActive(true);
            Player1.gameObject.SetActive(true);
            PlayerCount += 1;
        }
        else if (Player1Loaded == true)
        {
            Player1.gameObject.SetActive(false);
            Player1Loaded = false;
            Player1Toggle.gameObject.SetActive(false);
            PlayerCount -= 1;
            // Checking Player 2
            if (Player2Loaded == true) {
                Player2.gameObject.SetActive(false);
                Player2Loaded = false;
                Player2Toggle.gameObject.SetActive(false);
                PlayerCount -= 1;
            }
            // Checking Player 3
            if (Player3Loaded == true) {
                Player3.gameObject.SetActive(false);
                Player3Toggle.gameObject.SetActive(false);
                Player3Loaded = false;
                PlayerCount -= 1;
            }
            // Checking Player 4
            if (Player4Loaded == true) {
                Player4.gameObject.SetActive(false);
                Player4Toggle.gameObject.SetActive(false);
                Player4Loaded = false;
                PlayerCount -= 1;
            }
        }
    }
    // Loading Player 2
    public void LoadPlayer2()
    {
        if (Player1Loaded == true || Player2Loaded == true)
        {
            if (Player2Loaded == false)
            {
                Player2.gameObject.SetActive(true);
                Player2Loaded = true;
                Player2Toggle.gameObject.SetActive(true);
                PlayerCount += 1;
            }
            else if (Player2Loaded == true)
            {
                Player2.gameObject.SetActive(false);
                Player2Loaded = false;
                Player2Toggle.gameObject.SetActive(false);
                PlayerCount -= 1;
                // Checking Player 3
                if (Player3Loaded == true)
                {
                    Player3.gameObject.SetActive(false);
                    Player3Toggle.gameObject.SetActive(false);
                    Player3Loaded = false;
                    PlayerCount -= 1;
                }
                // Checking Player 4
                if (Player4Loaded == true)
                {
                    Player4.gameObject.SetActive(false);
                    Player4Toggle.gameObject.SetActive(false);
                    Player4Loaded = false;
                    PlayerCount -= 1;
                }
            }
        }
    }
    // Loading Player 3
    public void LoadPlayer3()
    {
        if (Player2Loaded == true || Player3Loaded == true)
        {
            if (Player3Loaded == false)
            {
                Player3.gameObject.SetActive(true);
                Player3Toggle.gameObject.SetActive(true);
                Player3Loaded = true;
                PlayerCount += 1;
            }
            else if (Player3Loaded == true)
            {
                Player3.gameObject.SetActive(false);
                Player3Toggle.gameObject.SetActive(false);
                Player3Loaded = false;
                PlayerCount -= 1;
                // Checking Player 4
                if (Player4Loaded == true)
                {
                    Player4.gameObject.SetActive(false);
                    Player4Toggle.gameObject.SetActive(false);
                    Player4Loaded = false;
                    PlayerCount -= 1;
                }
            }
        }
    }
    // Loading Player 4
    public void LoadPlayer4()
    {
        if (Player3Loaded == true || Player4Loaded == true)
        {
            if (Player4Loaded == false)
            {
                Player4.gameObject.SetActive(true);
                Player4Toggle.gameObject.SetActive(true);
                Player4Loaded = true;
                PlayerCount += 1;
            }
            else if (Player4Loaded == true)
            {
                Player4.gameObject.SetActive(false);
                Player4Toggle.gameObject.SetActive(false);
                Player4Loaded = false;
                PlayerCount -= 1;
            }
        }
    }
}