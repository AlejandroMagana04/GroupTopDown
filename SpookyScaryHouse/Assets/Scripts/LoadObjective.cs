using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadObjective : MonoBehaviour {

	public void Objective()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Objective");
    }
}
