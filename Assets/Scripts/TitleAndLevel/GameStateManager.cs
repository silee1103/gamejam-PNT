using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance { get; private set; }
    
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    public void StartStoryBtn()
    {
        SceneManager.LoadScene("Story2", LoadSceneMode.Single);
    }

    public void StartLevelBtn(){
        SceneManager.LoadScene("Choose", LoadSceneMode.Single);
    }

    public void QuitBtn()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}

