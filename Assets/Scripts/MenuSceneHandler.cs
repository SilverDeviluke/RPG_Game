﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneHandler : MonoBehaviour
{
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnOptionButtonClick()
    {

    }
}
