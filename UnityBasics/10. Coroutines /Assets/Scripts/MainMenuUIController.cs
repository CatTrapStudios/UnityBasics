﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour 
{
    public void OnPlayClicked()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
