using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{
    public void New()
    {
        
        Debug.Log("Starting New Game...");
        SceneManager.LoadScene("Game");

    }
}
