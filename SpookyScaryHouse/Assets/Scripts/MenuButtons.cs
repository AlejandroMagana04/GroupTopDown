﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtons : MonoBehaviour {

	public void NewGame()
    {
        SceneManager.LoadScene("Maze");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
