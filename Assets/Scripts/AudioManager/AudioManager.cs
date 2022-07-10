using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private AudioSource sfxPlayer;

    [SerializeField] private AudioClip sfxClip;

    public static AudioManager Instance { get; private set; }

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


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().name.IndexOf("Level") != -1)
        {
            Playsfx();
        }
    }

    public void Playsfx()
    {
        sfxPlayer.PlayOneShot(sfxClip);
    }

}
