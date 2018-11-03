using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject resumeButton;

    public Text score;
    private int remainingLives = 100;

    private void Start()
    {
        UpdateScore();
    }

    public void PauseButtonClicked()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
    }

    public void PlayButtonClicked()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
    }

    public void ArrowHitPlayer()
    {
        remainingLives--;
        UpdateScore();
    }

    private void UpdateScore()
    {
        score.text = remainingLives.ToString();
    }
}
