using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour 
{
	void Start ()
    {
        DontDestroyOnLoad(gameObject);	
	}

    public void LoadScene(string scene)
    {
        gameObject.SetActive(true);
        StartCoroutine(LoadSceneAsync(scene));
    }

    private IEnumerator LoadSceneAsync(string scene)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(scene);

        while (asyncOperation.progress < 1)
        {
            Debug.Log("Progress " + asyncOperation.progress);
            yield return new WaitForEndOfFrame();
        }

        Debug.Log("Complete!");
        gameObject.SetActive(false);
    }
}
