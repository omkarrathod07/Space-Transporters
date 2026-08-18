using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelStatusUi : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private Image fuelImage;
    private void Update()
    {
        UpdateDataText();
    }
    private void UpdateDataText()
    {
        UpdateLevelText();
        UpdateCoinText();
        UpdateScore();
        UpdateTimer();
        UpdateFuelBar();
        //Mathf.Round(Lander.Instance.GetFuel()) * 10 ;    
    }

    private void UpdateFuelBar()
    {
        fuelImage.fillAmount = Lander.Instance.GetFuelAmountNormalized();
    }

    private void UpdateTimer()
    {
        timerText.text = "" + Mathf.Round(GameManager.Instance.GetTime());
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + GameManager.Instance.GetScore();
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coin: " + GameManager.Instance.GetCurrentCoins() + ":" + GameManager.Instance.GetTotatCoins();
    }

    private void UpdateLevelText()
    {
        levelText.text = "Level: " + LevelManager.Instance.GetCurrentLevel();
    }
}
