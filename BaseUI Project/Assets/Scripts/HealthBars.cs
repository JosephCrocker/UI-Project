using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBars : MonoBehaviour
{
    public Text Player1Text;
    public Text Player2Text;
    public Text Player3Text;
    public Text Player4Text;

    public Slider Health1Slider;
    public Slider Health2Slider;
    public Slider Health3Slider;
    public Slider Health4Slider;

    public float Player1Health;
    public float Player2Health;
    public float Player3Health;
    public float Player4Health;


    public float EasyHealthDecreaseValue;
    public float MediumHealthDecreaseValue;
    public float HardHelathDecreaseValue;

    public UIManager MainManager;
    public UIItems Manager;

    void Start()
    {
        EasyHealthDecreaseValue = 5f;
        MediumHealthDecreaseValue = 10f;
        HardHelathDecreaseValue = 15f;

        Player1Health = 100;
        Player2Health = 100;
        Player3Health = 100;
        Player4Health = 100;
    }
    // Player 1 Update
    public void Player1HealthUpdate()
    {
        Player1Health = 100;
        if (Manager.Player1Loaded == true)
        {
            Debug.Log("Player 1 Has Loaded");
            Health1Slider.gameObject.SetActive(true);
            Player1Text.gameObject.SetActive(true);
            Health1Slider.value = Player1Health;
        }
        else if (Manager.Player1Loaded == false)
        {
            Health1Slider.gameObject.SetActive(false);
            Player1Text.gameObject.SetActive(false);
        }
    }
    // Player 2 Update
    public void Player2HealthUpdate()
    {
        Player2Health = 100;
        if (Manager.Player2Loaded == true)
        {
            Debug.Log("Player 2 Has Loaded");
            Health2Slider.gameObject.SetActive(true);
            Player2Text.gameObject.SetActive(true);
            Health2Slider.value = Player2Health;
        }
        else if (Manager.Player2Loaded == false)
        {
            Health2Slider.gameObject.SetActive(false);
            Player2Text.gameObject.SetActive(false);
        }
    }
    // Player 3 Update
    public void Player3HealthUpdate()
    {
        Player3Health = 100;
        if (Manager.Player3Loaded == true)
        {
            Debug.Log("Player 3 Has Loaded");
            Health3Slider.gameObject.SetActive(true);
            Player3Text.gameObject.SetActive(true);
            Health3Slider.value = Player3Health;
        }
        else if (Manager.Player3Loaded == false)
        {
            Health3Slider.gameObject.SetActive(false);
            Player3Text.gameObject.SetActive(false);
        }
    }
    // Player 4 Update
    public void Player4HealthUpdate()
    {
        Player4Health = 100;
        if (Manager.Player4Loaded == true)
        {
            Debug.Log("Player 4 Has Loaded");
            Health4Slider.gameObject.SetActive(true);
            Player4Text.gameObject.SetActive(true);
            Health4Slider.value = Player4Health;
        }
        else if (Manager.Player4Loaded == false)
        {
            Health4Slider.gameObject.SetActive(false);
            Player4Text.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        //-----------------------------------------------------//
        // If Health < 0 Reset Value
        if (Player1Health <= 0){
            Player1Health = 0;
        }
        if (Player2Health <= 0)
        {
            Player2Health = 0;
        }
        if (Player3Health <= 0)
        {
            Player3Health = 0;
        }
        if (Player4Health <= 0)
        {
            Player4Health = 0;
        }
        //-----------------------------------------------------//
        // Setting Remaining Values
        Health1Slider.value = Player1Health;
        Health2Slider.value = Player2Health;
        Health3Slider.value = Player3Health;
        Health4Slider.value = Player4Health;
        // Checking & Updating Values
        if (Player1Health > 0 || Player2Health > 0 || Player3Health > 0 || Player4Health > 0)
        {
            if (MainManager.Easy == true)
            {
                Player1Health -= EasyHealthDecreaseValue * Time.deltaTime;
                Player2Health -= EasyHealthDecreaseValue * Time.deltaTime;
                Player3Health -= EasyHealthDecreaseValue * Time.deltaTime;
                Player4Health -= EasyHealthDecreaseValue * Time.deltaTime;
            }
            if (MainManager.Medium == true)
            {
                Player1Health -= MediumHealthDecreaseValue * Time.deltaTime;
                Player2Health -= MediumHealthDecreaseValue * Time.deltaTime;
                Player3Health -= MediumHealthDecreaseValue * Time.deltaTime;
                Player4Health -= MediumHealthDecreaseValue * Time.deltaTime;
            }
            if (MainManager.Hard == true)
            {
                Player1Health -= HardHelathDecreaseValue * Time.deltaTime;
                Player2Health -= HardHelathDecreaseValue * Time.deltaTime;
                Player3Health -= HardHelathDecreaseValue * Time.deltaTime;
                Player4Health -= HardHelathDecreaseValue * Time.deltaTime;
            }
        }
        //-----------------------------------------------------//
    }
}