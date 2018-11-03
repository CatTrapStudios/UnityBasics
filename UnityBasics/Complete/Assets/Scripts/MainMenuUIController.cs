using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour 
{
    public GameObject playButton;
    public LoadingScreen loadingScreen;

    private void Start()
    {
        playButton.SetActive(false);
        StartCoroutine(EnablePlayButtonAfterDelay());
    }

    private IEnumerator EnablePlayButtonAfterDelay()
    {
        yield return new WaitForSeconds(1.5f);
        playButton.SetActive(true);
    }

    public void OnPlayClicked()
    {
        loadingScreen.LoadScene("Tutorial");
    }
}
