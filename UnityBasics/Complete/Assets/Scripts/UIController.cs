using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject resumeButton;

    public Text score;
    private SaveData saveData;
    private SaveDataSerializer saveDataSerializer;

    private void Start()
    {
        SetUpSaveData();

        UpdateScore();
    }

    private void SetUpSaveData()
    {
        saveDataSerializer = new SaveDataSerializer();

        saveData = saveDataSerializer.Load();

        if (saveData == null)
        {
            saveData = new SaveData();
            saveData.remainingLives = 100;
            saveDataSerializer.Save(saveData);
        }
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
        saveData.remainingLives--;
        UpdateScore();

        saveDataSerializer.Save(saveData);
    }

    private void UpdateScore()
    {
        score.text = saveData.remainingLives.ToString();
    }
}
