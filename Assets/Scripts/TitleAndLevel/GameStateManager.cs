using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameStateManager : MonoBehaviour
{

    public void StartStoryBtn()
    {
        SceneManager.LoadScene("Story1", LoadSceneMode.Single);
    }

    public void StartLevelBtn(){
        SceneManager.LoadScene("LevelChoose", LoadSceneMode.Single);
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

