using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

    public List<char> dialogueOrder = new List<char>();
    
    public List<string> Alist = new List<string>() ;
    public List<string> Ulist = new List<string>() ;
    public List<string> Nlist = new List<string>() ;

    public GameObject panelA;
    public GameObject panelU;
    public GameObject panelN;

    public int nextSceneNumber;

    private int A_number = 0;
    private int U_number = 0;
    private int N_number = 0;

    void Awake(){
/*
        panelA = GameObject.FindWithTag("Canvas").transform.Find("DialogPanelA").gameObject ;
        panelU = GameObject.FindWithTag("Canvas").transform.Find("DialogPanelN").gameObject ;
        panelN = GameObject.FindWithTag("Canvas").transform.Find("DialogPanelU").gameObject ;
*/

        panelA.SetActive(false);
        panelU.SetActive(false);
        panelN.SetActive(false);
    }

    void Update(){
        if (Input.GetMouseButtonDown(0))
        {
            StoryNextBtn();
        }
       
    }

    public void StoryNextBtn(){
        int currentOrder = A_number+U_number+N_number;

        if (currentOrder >= dialogueOrder.Count)
        {
            string stageName = SceneManager.GetActiveScene().name;
            if (stageName == "StoryEnd")
            {
                GameStateManager.Instance.QuitBtn();
            }
            else
            {
                SceneManager.LoadScene(nextSceneNumber, LoadSceneMode.Single);
            }

        }

        char speaker = dialogueOrder[currentOrder];

        string text;

        switch (speaker)
        {
            case 'A':
                text = Alist[A_number];
                panelA.GetComponentInChildren<Text>().text = text;

                panelA.SetActive(true);
                panelU.SetActive(false);
                panelN.SetActive(false);

                A_number++;

                break;

            case 'U':
                text = Ulist[U_number];
                panelU.GetComponentInChildren<Text>().text = text;

                panelU.SetActive(true);
                panelA.SetActive(false);
                panelN.SetActive(false);
                
                U_number++;

                break;

            case 'N':
                text = Nlist[N_number];
                panelN.GetComponentInChildren<Text>().text = text;

                panelN.SetActive(true);
                panelU.SetActive(false);
                panelA.SetActive(false);
                
                N_number++;

                break;
            
            default:
                break;
                
        }


        
    }

}
