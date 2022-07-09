using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChooseManager : MonoBehaviour
{
    public int sceneNumber;

    public void LevelBtn()
    {
        SceneManager.LoadScene(sceneNumber, LoadSceneMode.Single);
    }
}
